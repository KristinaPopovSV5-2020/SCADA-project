using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Models
{

    [DataContract]
    public class AnalogOutput: OutputTag
    {

        [DataMember]
        private double lowLimit;

        [DataMember]
        private double highLimit;

        [DataMember]
        private string units;

        public AnalogOutput(): base() { }


        public AnalogOutput(string tagName, string desc, string ioAddress, double initialValue, double lowLimit, double highLimit, string units) : base(tagName, desc, ioAddress, initialValue)
        {
            
            this.lowLimit = lowLimit;
            this.highLimit = highLimit;
            this.units = units;
        }

        public double LowLimit { get; set; }
        public double HighLimit { get; set; }

        public string Units { get; set; }



    }
}