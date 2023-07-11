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
    public class ScadaService : IDbManager, IRTU, IAlarmDisplay
    {
        static RealTimeDriver realTimeDriver = new RealTimeDriver();
        static SimulationDriver simulationDriver = new SimulationDriver();

        static Dictionary<int, string> realTimeUnits = new Dictionary<int, string>();

        public static AlarmManager alarmManager = new AlarmManager();
        public TagManager tagManager = new TagManager(alarmManager);
        public UserManager userManager = new UserManager();
        //public static SimulationDriver simulationDriver;

        static IAlarmDisplayCallback alarmProxy = null;


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

        void IDbManager.AddTag(Tag tag)
        {
            throw new NotImplementedException();
        }

        void IDbManager.DoWork()
        {
            throw new NotImplementedException();
        }

        public void initializationAlarmDisplay()
        {
            alarmProxy = OperationContext.Current.GetCallbackChannel<IAlarmDisplayCallback>();
        }
    }
}
