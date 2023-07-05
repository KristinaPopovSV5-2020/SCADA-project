using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class DigitalOutput: OutputTag
    {

        public DigitalOutput(): base() { }

        public DigitalOutput(string tagName, string desc, string ioAddress, double initialValue) : base(tagName, desc, ioAddress, initialValue)
        {

        }
    }
}