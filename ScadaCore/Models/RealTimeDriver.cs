using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [DataContract]
    public class RealTimeDriver: Driver
    {
        [DataMember]
        private int numberOfAddresses = 5;

        [DataMember]
        private Dictionary<string, double> addrValues;


        public RealTimeDriver()
        {
            addrValues = new Dictionary<string, double>();

            for (int i = 0; i<= numberOfAddresses; i++)
            {
                addrValues["address" + i.ToString()] = 0;
            }
        }

        public double ReturnValue(string address)
        {
            if (addrValues.ContainsKey(address))
            {
                return addrValues[address];

            }
            
             return -3333;
           
        }

        public bool WriteValue(string address, double value)
        {
            if (addrValues.ContainsKey(address))
            {
                addrValues[address] = value;
                return true;
            }
            return false;

        }

        public Dictionary<string, double> AddrValues
        {
            get { return addrValues; }
        }

        public List<string> getAvailableAddress()
        {
            List<string> addresses = new List<string>();
            foreach(string address in addrValues.Keys)
            {
                if (addrValues[address] == 0)
                {
                    addresses.Add(address);
                }
                
            }
            return addresses;
        }

        public bool checkAddressAvailable(string a)
        {
            if (addrValues.ContainsKey(a))
            {
                if (addrValues[a] == 0)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
