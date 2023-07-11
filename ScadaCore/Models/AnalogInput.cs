using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Models
{
    [DataContract]

    public class AnalogInput: InputTag
    {

        [DataMember]
        private List<Alarm> alarms;

        [DataMember]
        private double lowLimit;

        [DataMember]
        private double highLimit;

        [DataMember]
        private string units;


        public AnalogInput(): base() { }
    


     
        public AnalogInput(string tagName, string desc, string ioAddress, Driver driver, int scanTime,
            bool scan, List<Alarm> alarms, double lowLimit, double highLimit, string units, double initialValue) : base(tagName, desc, ioAddress, driver,  scanTime,
             scan, initialValue) {
            this.alarms = alarms;
            this.lowLimit = lowLimit;
            this.highLimit = highLimit;
            this.units = units;
        }

        public List<Alarm>  Alarms {
            get { return alarms; }
            set { alarms = value; }
        }

        public double LowLimit {
            get { return lowLimit; }
            set { lowLimit = value; }
        }
        public double HighLimit {
            get { return highLimit; }
            set { highLimit = value; }
        }

        public string Units {
            get { return units; }
            set { units = value; }
        }


    }
}