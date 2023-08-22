using Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Xml.Serialization;

namespace ScadaCore
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service.svc or Service.svc.cs at the Solution Explorer and start debugging.

    public class ScadaService : IDbManager, IRTU, IAlarmDisplay, ITrending, IReportManager
    {
        static Dictionary<string, Thread> threads = new Dictionary<string, Thread>();

       

        static RealTimeDriver rtu = new RealTimeDriver();
        public static SimulationDriver simulationDriver = new SimulationDriver();

        static string currentPath = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath;

        public static AlarmManager alarmManager = new AlarmManager(currentPath);
        public static TagManager tagManager = new TagManager(alarmManager, currentPath);
        public static UserManager userManager = new UserManager(currentPath);

        static ITrendingCB trending = null;

        static IAlarmDisplayCallback alarmProxy = null;


        public bool addAddress(string address)
        {
            lock (rtu)
            {
                if (!rtu.checkAddressAvailable(address))
                {
                    rtu.AddNewAddress(address);
                    return true;
                }
            }
            lock (simulationDriver)
            {
                if (!simulationDriver.checkAddressAvailable(address))
                {
                    simulationDriver.AddNewAddress(address);
                    return true;
                }
            }

            return false;
        }

        public List<string> getAvailableAddresses()
        {
            lock (rtu)
            {
                return rtu.getAvailableAddress();
            }
        }

        public void sendToService(string address, double value)
        {
            lock (rtu)
            {
                rtu.WriteValue(address, value);

            }
            Tag ta = new Tag();
            foreach (Tag t in tagManager.tags.Values)
            {

                if (t.IOAddress == address)
                {
                    ta = t;
                    break;
                }
            }
            processTag(ta.TagName);
        }




        public void initTrending()
        {
            trending = OperationContext.Current.GetCallbackChannel<ITrendingCB>();
        }

        public void processTag(string tagName)
        {


            if (tagManager.tags[tagName] is InputTag)
                threads[tagName] = new Thread(new ParameterizedThreadStart(processInputTag));
            
            else if (tagManager.tags[tagName] is OutputTag)
                threads[tagName] = new Thread(new ParameterizedThreadStart(processOutputTag));

            threads[tagName].Start(tagName);

        }

        private void processInputTag(object tag)
        {
            string tagName = (string) tag;

            while (true)
            {
                double value = 0;


                if ((tagManager.tags[tagName] as InputTag).Driver is RealTimeDriver)
                {
                    lock (rtu)
                    {
                        value = rtu.ReadValue(tagManager.tags[tagName].IOAddress);
                    }

                }
                else
                {

                    //ako je simulacioni
                    if ((tagManager.tags[tagName] as InputTag).Scan == true) //ako je ukljuceno skeniranje
                    {
                        lock (simulationDriver)
                        {
                            value = simulationDriver.ReadValue(tagManager.tags[tagName].IOAddress);
                        }
                    }
                    else
                    {
                        lock (simulationDriver)
                        {
                            value = simulationDriver.ReadCurrentValue(tagManager.tags[tagName].IOAddress); 
                            simulationDriver.WriteDefaultValue(tagManager.tags[tagName].IOAddress, 0);

                        }
                    }

                }


                //provera za alarm da li se dogodio
                if (tagManager.tags[tagName] is AnalogInput)
                {
                    foreach (Alarm alarm in ((tagManager.tags[tagName] as AnalogInput).Alarms))
                    {
                        if ((alarm.Type == TypeOfAlarm.Low && alarm.Limit > value) || (alarm.Type == TypeOfAlarm.High && alarm.Limit < value))
                        {
                            if (alarmProxy != null)
                            {
                                DateTime currentTime = DateTime.Now;
                                alarm.Time = currentTime;
                                alarm.TagValue = value;

                                //ispisi na konzolu ako je ukljuceno skeniranje
                                if ((tagManager.tags[tagName] as InputTag).Scan == true)
                                {

                                    alarmProxy.showAlarmDisplay(alarm);
                                }

                                lock (alarmManager)
                                {
                                    alarmManager.SaveNewAlarmToFile(alarm);
                                }

                            }
                        }
                    }

                }

                tagManager.WriteToLog(tagManager.tags[tagName], value);
                tagManager.XmlSerialization();
                if (trending != null)
                    trending.addTagValue(tagName, value);

                Thread.Sleep(1000*(tagManager.tags[tagName] as InputTag).ScanTime);
            }
        }
 
        public void processOutputTag(object tag)
        {
            string tagName = (string)tag;
            tagManager.XmlSerialization();

        }

        public List<User> GetAllUsers()
        {
            return userManager.users;
        }
        
        public bool AddTag(Tag tag, bool realTimeOn)
        {
            if (tagManager.tags.ContainsKey(tag.TagName) || simulationDriver.Addresses.Contains(tag.IOAddress)) return false;

            else
            {
                tagManager.tags.Add(tag.TagName, tag);
                if (tag is InputTag)
                {
                    InputTag iTag = (InputTag)tag;
                    if (realTimeOn)
                        iTag.Driver = rtu;
                    else
                        iTag.Driver = simulationDriver;
                    addAddress(iTag.IOAddress);
                    tagManager.SaveNewTagToFile(iTag);
                }
                else
                {
                    OutputTag oTag = (OutputTag)tag;
                    tagManager.SaveNewTagToFile(oTag);

                }
                tagManager.XmlSerialization();
                return true;
            }

        }


        public void initializationAlarmDisplay()
        {
            alarmProxy = OperationContext.Current.GetCallbackChannel<IAlarmDisplayCallback>();
        }

        public void DeleteTag(string tagId)
        {
            Tag selectedTag = tagManager.tags[tagId];
            tagManager.tags.Remove(tagId);
            tagManager.XmlSerialization();
        }

        public List<AnalogOutput> GetAnalogOutputTags()
        {
            return tagManager.tags.Values
           .Where(tag => tag is AnalogOutput) 
           .Cast<AnalogOutput>()               
           .ToList();
        }

        public List<AnalogInput> GetAnalogInputTags()
        {
            return tagManager.tags.Values
           .Where(tag => tag is AnalogInput)
           .Cast<AnalogInput>()
           .ToList();
        }

        public List<DigitalInput> GetDigitalInputTags()
        {
            return tagManager.tags.Values
           .Where(tag => tag is DigitalInput)
           .Cast<DigitalInput>()
           .ToList();
        }

        public List<DigitalOutput> GetDigitalOutputTags()
        {
            return tagManager.tags.Values
           .Where(tag => tag is DigitalOutput)
           .Cast<DigitalOutput>()
           .ToList();
        }

        public void OnOffScan(string tagId)
        {
            Tag tag = tagManager.tags[tagId];

            if (tag is AnalogInput analogInput)
            {
                analogInput.Scan = !analogInput.Scan;
                tagManager.tags[tagId] = analogInput;
            }
            else if (tag is DigitalInput digitalInput)
            {
                digitalInput.Scan = !digitalInput.Scan;
                tagManager.tags[tagId] = digitalInput;
            }
            tagManager.XmlSerialization();
        }

        public void UpdateValue(string tagId, double value)
        {
            tagManager.tags[tagId].InitialValue = value;
            tagManager.WriteToLog(tagManager.tags[tagId], value);
            processTag(tagId);
        }

        public void newAlarm(Alarm alarm)
        {
            AnalogInput input = (AnalogInput)tagManager.tags[alarm.TagId];
            input.Alarms.Add(alarm);
            tagManager.tags[alarm.TagId] = input;
            tagManager.XmlSerialization();
        }

        public void deleteAlarm(string alarmId, string tagId)
        {
            AnalogInput input = (AnalogInput)tagManager.tags[tagId];
            foreach (Alarm alarm in input.Alarms)
            {
                if (alarm.AlarmId == alarmId) input.Alarms.Remove(alarm);
                break;
            }
            tagManager.tags[tagId] = input;
            tagManager.XmlSerialization();
        }

        public List<Alarm> findAlarm(string tagId)
        {
            AnalogInput input = (AnalogInput)tagManager.tags[tagId];
            return input.Alarms;
        }

        public static void XmlSerialisation()
        {
            using (var writer = new StreamWriter("/Database/scadaConfig.xml"))
            {
                var serializer = new XmlSerializer(typeof(List<Tag>));
                serializer.Serialize(writer, tagManager.tags.Values.ToList());
                Console.WriteLine("Serialization finished");
            }

        }

        public List<Alarm> alarmsSpecifiedTimePeriodSortByPriority(DateTime start, DateTime end)
        {
            var sortedAlarms = alarmManager.alarms
            .Where(alarm => alarm.Time >= start && alarm.Time <= end)
            .OrderBy(alarm => alarm.Priority).ToList<Alarm>();

            return sortedAlarms;
        }

        public List<Alarm> alarmsSpecifiedTimePeriodSortByTime(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public List<Alarm> alarmsSpecifiedPrioritySortByTime(string priority)
        {
            return alarmManager.alarms
           .Where(alarm => alarm.Priority == priority)
           .OrderBy(alarm => alarm.Time).ToList();
        }

        public List<Log> tagsSpecifiedTimePeriodSortByTime(DateTime start, DateTime end)
        {
            return tagManager.logs
            .Where(log => log.dateTime >= start && log.dateTime <= end)
            .OrderBy(log=>log.dateTime)
            .ToList();
        }

        public List<Log> lastValueOfAITagsSortByTime()
        {
            return tagManager.logs
            .Where(log => log.type == "ai")
            .GroupBy(log => log.tagName)
            .Select(group => group.OrderByDescending(log => log.dateTime).First())
            .OrderBy(log=>log.dateTime)
            .ToList();
        }

        public List<Log> lastValueOfDITagsSortByTime()
        {
            return tagManager.logs
            .Where(log => log.type == "di")
            .GroupBy(log => log.tagName)
            .Select(group => group.OrderByDescending(log => log.dateTime).First())
            .OrderBy(log => log.dateTime)
            .ToList();
        }

        public List<Log> tagValuesSpecificIdSortByValue(string tagId)
        {
            return tagManager.logs
                .Where(log => log.tagName == tagId)
                .OrderBy(log => log.value)
                .ToList();
        }

        public bool Register(string username, string password)
        {
            if (userManager.users.Any(user => user.username == username))
            {
                return false; 
            }

            User newUser = new User(username, password);
            userManager.users.Add(newUser);
            userManager.SaveUsersToFile();

            return true; 
        }
    }
}
