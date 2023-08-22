using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [DataContract]
    public class SimulationDriver: Driver
    {
        [DataMember]
        private int numberOfAddresses = 10;

        [DataMember]
        private List<string> addresses;

        [DataMember]
        private List<double> tagValues;

        public SimulationDriver()
        {
            this.addresses = new List<string>();
            this.tagValues = new List<double>();

            //inicijalizujemo adrese i vrednosti 
            for (int i = 1; i <= numberOfAddresses; i++)
            {
                addresses.Add("address" + i);
                tagValues.Add(0);
            }

        }

        public double ReadValue(string address)
        {
            try
            {
                int i = addresses.IndexOf(address);
                double randomValue = ReturnRandomValue(i);
                tagValues[i] = randomValue;
                return tagValues[i];
            }
            catch (Exception)
            {
                return -3333;
            }


        }

        public void AddNewAddress(string address)
        {
            addresses.Add(address);
            tagValues.Add(0);
        }

        public bool checkAddressAvailable(string address)
        {
            if (addresses.Contains(address))
            {
                return true;
            }
            return false;
        }
        public double ReturnRandomValue(int i)
        {
            double v = 0;
     
            if (i >= 10)
            {
                v = Ramp();

            }
            else
            {
                if (i % 2 == 0)
                {
                    v = Sine();
                }
                else
                {
                    v = Cosine();
                }
            }
            return v;
            
            
        }

        private static double Sine()
        {
            return 100 * Math.Sin((double)DateTime.Now.Second / 60 * Math.PI);
        }

        private static double Cosine()
        {
            return 100 * Math.Cos((double)DateTime.Now.Second / 60 * Math.PI);
        }

        private static double Ramp()
        {
            return 100 * DateTime.Now.Second / 60;
        }


        public List<double> TagValues
        {
            get { return tagValues; }
            set { tagValues = value; }
        }

        public List<string> Addresses
        {
            get { return addresses; }
            set { addresses = value; }
        }


        public bool WriteDefaultValue(string address, int value)
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

        public double ReadCurrentValue(string address)
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

    }
}
