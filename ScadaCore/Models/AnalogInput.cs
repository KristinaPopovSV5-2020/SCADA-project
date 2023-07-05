using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Models
{
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
            bool scan, List<Alarm> alarms, double lowLimit, double highLimit, string units) : base(tagName, desc, ioAddress, driver,  scanTime,
             scan) {
            this.alarms = alarms;
            this.lowLimit = lowLimit;
            this.highLimit = highLimit;
            this.units = units;
        }

        public List<Alarm>  Alarms { get; set; }

        public double LowLimit { get; set; }
        public double HighLimit { get; set; }

        public string Units { get; set; }


    }
}