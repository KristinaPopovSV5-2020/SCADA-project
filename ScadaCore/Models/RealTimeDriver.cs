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
        public List<string> addresses;

        [DataMember]
        public List<double> tagValues;


        public RealTimeDriver()
        {
            addresses = new List<string>();
            tagValues = new List<double>();
        }

        public double ReadValue(string address)
        {
            try
            {
                int i = addresses.IndexOf(address);
                return tagValues[i];
            }
            catch (Exception)
            {
                return -3333;
            }

        }

        public bool WriteValue(string address, double value)
        {
            try
            {
                int i = addresses.IndexOf(address);
                tagValues[i] = value;
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }


        public void AddNewAddress(string address)
        {
            this.addresses.Add(address);
            this.tagValues.Add(0);
        }

        public List<string> getAvailableAddress()
        {
             return addresses;
        }

        public bool checkAddressAvailable(string a)
        {
            if (addresses.Contains(a))
            {
                return true;
            }

            return false;
        }

    }
}
