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
        private int numberOfAddresses = 10;

        [DataMember]
        private Dictionary<string, double> addrValues;


        public RealTimeDriver()
        {
            addrValues = new Dictionary<string, double>();
            for (int i = 1; i <= numberOfAddresses; i++)
            {
                addrValues["address" + i] = 0;
            }
        }

        public double ReadValue(string address)
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

        public List<double> AddrValues
        {
            get { return addrValues.Values.ToList(); }
        }


        public void AddNewAddress(string address)
        {
            this.addrValues.Add(address, 0);
        }

        public List<string> getAvailableAddress()
        {
             return addrValues.Keys.ToList<string>();
        }

        public bool checkAddressAvailable(string a)
        {
            if (addrValues.ContainsKey(a))
            {
                return true;
            }

            return false;
        }

    }
}
