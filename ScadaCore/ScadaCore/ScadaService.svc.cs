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

    public class ScadaService : IDbManager, IRTU, IAlarmDisplay, ITrending
    {
        static Dictionary<string, Tag> tags = new Dictionary<string, Tag>();
        static Dictionary<string, Thread> threads = new Dictionary<string, Thread>();

        static Dictionary<int, string> realTimeUnits = new Dictionary<int, string>();

        static RealTimeDriver rtu = new RealTimeDriver();
        static string currentPath = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath;

        public static AlarmManager alarmManager = new AlarmManager(currentPath);
        public static TagManager tagManager = new TagManager(alarmManager, currentPath);
        public UserManager userManager = new UserManager(currentPath);

        static ITrendingCB trending = null;
        public static SimulationDriver simulationDriver = new SimulationDriver();

        static IAlarmDisplayCallback alarmProxy = null;

        static Dictionary<string, Alarm> alarmConfig = new Dictionary<string, Alarm>();



        public bool addAddress(string address)
        {
            lock (rtu)
            {
                if (rtu.checkAddressAvailable(address))
                {
                    realTimeUnits[realTimeUnits.Count + 1] = address;
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
        }




        public void initTrending()
        {
            trending = OperationContext.Current.GetCallbackChannel<ITrendingCB>();
        }

        public void processTag(string tagName)
        {

            if (threads.ContainsKey(tagName))
                return;

            if (tags[tagName] is InputTag)
                threads[tagName] = new Thread(new ParameterizedThreadStart(processInputTag));
            
            else if (tags[tagName] is OutputTag)
                //threads[tagName] = new Thread(new ParameterizedThreadStart(processOutputTag));

            threads[tagName].Start(tagName);

        }

        private void processInputTag(object tag)
        {
            string tagName = (string) tag;

            while (true)
            {
                double value = 0;

                if (!tags.ContainsKey(tagName))
                    return;
                

                if ((tags[tagName] as InputTag).Driver is RealTimeDriver)
                {
                    lock (rtu)
                    {
                        value = rtu.ReadValue(tags[tagName].IOAddress);
                    }
                }
                else
                {
                    //ako je simulacioni
                    if ((tags[tagName] as InputTag).Scan == true) //ako je ukljuceno skeniranje
                    {
                        lock (simulationDriver)
                        {
                            value = simulationDriver.ReadValue(tags[tagName].IOAddress);
                        }
                    }
                    else
                    {
                        lock (simulationDriver)
                        {
                            value = simulationDriver.ReadCurrentValue(tags[tagName].IOAddress); 
                            simulationDriver.WriteDefaultValue(tags[tagName].IOAddress, 0);

                        }
                    }

                }

                //provera za alarm da li se dogodio
                foreach (Alarm alarm in ((tags[tagName] as AnalogInput).Alarms))
                {
                    if ((alarm.Type == TypeOfAlarm.Low && alarm.Limit > value) || (alarm.Type == TypeOfAlarm.High && alarm.Limit < value))
                    {
                        if (alarmProxy != null)
                        {
                            DateTime currentTime = DateTime.Now;
                            alarm.Time = currentTime;
                            alarm.TagValue = value;

                            //ispisi na konzolu ako je ukljuceno skeniranje
                            if ((tags[tagName] as InputTag).Scan == true)
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



                trending.addTagValue(tagName, value);
                Thread.Sleep(1000*(tags[tagName] as InputTag).ScanTime);
            }
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
                        iTag.Driver = simulationDriver;
                    else
                        iTag.Driver = simulationDriver;
                    tagManager.SaveNewTagToFile(iTag);
                }
                else
                {
                    OutputTag oTag = (OutputTag)tag;
                    tagManager.SaveNewTagToFile(oTag);

                }
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
        }

        public void UpdateValue(string tagId, double value)
        {
            tagManager.tags[tagId].InitialValue = value;
        }

        public void newAlarm(Alarm alarm)
        {
            alarmConfig.Add(alarm.AlarmId, alarm);
        }

        public void deleteAlarm(string alarmId)
        {
            alarmConfig.Remove(alarmId);
        }

        public List<Alarm> findAlarm(string tagId)
        {
            List<Alarm> foundAlarms = new List<Alarm>();

            foreach (Alarm alarm in alarmConfig.Values)
            {
                if (alarm.TagId == tagId)
                {
                    foundAlarms.Add(alarm);
                }
            }

            return foundAlarms;
        }

        public static void XmlSerialisation()
        {
            using (var writer = new StreamWriter("/Database/scadaConfig.xml"))
            {
                var serializer = new XmlSerializer(typeof(List<Tag>));
                serializer.Serialize(writer, tags.Values.ToList());
                Console.WriteLine("Serialization finished");
            }

        }

    }
}
