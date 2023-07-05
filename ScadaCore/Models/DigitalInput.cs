using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class DigitalInput: InputTag
    {

        public DigitalInput() : base() { }

        public DigitalInput(string id, string desc, string ioaddress, Driver driver, int time,
            bool sc) : base(id, desc, ioaddress,driver, time, sc) { }


    }

}