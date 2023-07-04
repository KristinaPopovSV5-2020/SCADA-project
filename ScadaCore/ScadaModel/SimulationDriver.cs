using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ScadaModel
{
    [DataContract]
    public class SimulationDriver
    {

        [DataMember]
        private List<string> addresses;

        [DataMember]
        private List<double> tagValues;

        public SimulationDriver()
        {
            this.addresses = new List<string>();
            this.tagValues = new List<double>();

        }

        public double ReturnValue(string address)
        {
            try
            {
                int i = addresses.IndexOf(address);
                return tagValues[i];
            }
            catch (Exception)
            {
                return -5555;
            }


        }

        public void WriteValue(string address)
        {
            double v = 0;
            try
            {
                int i = addresses.IndexOf(address);
                
            }
            catch (Exception e)
            {
                addresses.Add(address);
                int i = addresses.IndexOf(address);
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
                tagValues.Add(v);
            }
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




    }
}