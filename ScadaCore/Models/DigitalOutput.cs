using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Models
{
    [DataContract]

    public class DigitalOutput: OutputTag
    {

        public DigitalOutput(): base() { }

        public DigitalOutput(string tagName, string desc, string ioAddress, double initialValue) : base(tagName, desc, ioAddress, initialValue)
        {

        }
    }
}