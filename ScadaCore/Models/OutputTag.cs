using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Models
{
    [DataContract]

    [KnownType(typeof(DigitalOutput))]
    [KnownType(typeof(AnalogOutput))]
    public class OutputTag: Tag
    {


        public OutputTag(): base() { }

        public OutputTag(string id, string desc, string ioAddress, double initialValue) : base(id, desc, ioAddress, initialValue)
        {
        }

    }
}