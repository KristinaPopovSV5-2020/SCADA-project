using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Models
{
    [DataContract]

    public class DigitalInput : InputTag
    {

        public DigitalInput() : base() { }

        public DigitalInput(string id, string desc, string ioaddress, Driver driver, int time,
            bool sc, double initialValue) : base(id, desc, ioaddress, driver, time, sc, initialValue) { }


    }

}