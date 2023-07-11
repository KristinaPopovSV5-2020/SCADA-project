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
        static SimulationDriver simulationDriver = new SimulationDriver();

        static ITrendingCB trending = null;


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
                        value = rtu.ReturnValue(tags[tagName].IOAddress);
                    }
                }
                else
                {
                   //ako je simulacioni

                }

                trending.addTagValue(tagName, value);
                Thread.Sleep(1000*(tags[tagName] as InputTag).ScanTime);
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
