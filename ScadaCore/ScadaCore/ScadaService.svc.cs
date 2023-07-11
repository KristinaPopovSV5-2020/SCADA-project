using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ScadaCore
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service.svc or Service.svc.cs at the Solution Explorer and start debugging.
    public class ScadaService : IDbManager, IRTU
    {
        static RealTimeDriver realTimeDriver = new RealTimeDriver();
        static SimulationDriver simulationDriver = new SimulationDriver();
        static string currentPath = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath;


        static Dictionary<int, string> realTimeUnits = new Dictionary<int, string>();

        public static AlarmManager alarmManager = new AlarmManager(currentPath);
        public TagManager tagManager = new TagManager(alarmManager, currentPath);
        public UserManager userManager = new UserManager(currentPath);
        //public static SimulationDriver simulationDriver;


        public bool addAddress(string address)
        {
            lock (realTimeDriver)
            {
                if (realTimeDriver.checkAddressAvailable(address))
                {
                    realTimeUnits[realTimeUnits.Count + 1] = address;
                    return true;
                }
            }

            return false;
        }

        public List<string> getAvailableAddresses()
        {
            lock (realTimeDriver)
            {
                return realTimeDriver.getAvailableAddress();
            }
        }

        public void sendToService(string address, double value)
        {
            lock (realTimeDriver)
            {
                realTimeDriver.WriteValue(address, value);
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

        public List<Tag> GetOutputTags()
        {
            return tagManager.tags.Values.ToList().Where(tag => tag is OutputTag).ToList();
        }
    }
}
