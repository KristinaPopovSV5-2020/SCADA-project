using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

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
        public TagManager tagManager = new TagManager(alarmManager, currentPath);
        public UserManager userManager = new UserManager(currentPath);

        static ITrendingCB trending = null;
        public static SimulationDriver simulationDriver = new SimulationDriver();

        static IAlarmDisplayCallback alarmProxy = null;


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
                Tag ta=new Tag();
                foreach(Tag t in tags.Values)
                {
                    processTag(t.TagName);
                    if (t.IOAddress==address)
                    {
                        ta = t;
                        break;
                    }
                }
                //processTag(ta.TagName);
            }
        }




        public void initTrending()
        {
            trending = OperationContext.Current.GetCallbackChannel<ITrendingCB>();
        }

        public void processTag(string tagName)
        {

            if (tags[tagName] is InputTag)
                threads[tagName] = new Thread(new ParameterizedThreadStart(processInputTag));
            
            else if (tags[tagName] is OutputTag)
                threads[tagName] = new Thread(new ParameterizedThreadStart(processOutputTag));

            threads[tagName].Start(tagName);

        }

        private void processInputTag(object tag)
        {
            string tagName = (string) tag;

            while (true)
            {
                double value = 0;

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
 
        public void processOutputTag(object tag)
        {
            string tagName = (string)tag;

            //nesto

        }
        public List<User> getUsers()
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

        public List<Tag> GetOutputTags()
        {
            return tagManager.tags.Values.ToList().Where(tag => tag is OutputTag).ToList();
        }

        public void initializationAlarmDisplay()
        {
            alarmProxy = OperationContext.Current.GetCallbackChannel<IAlarmDisplayCallback>();
        }

    }
}
