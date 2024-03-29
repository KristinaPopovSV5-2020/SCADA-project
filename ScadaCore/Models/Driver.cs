﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Models
{
    [DataContract]
    [KnownType(typeof(RealTimeDriver))]
    [KnownType(typeof(SimulationDriver))]
    public class Driver
    {
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}