using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace Models
{
    [DataContract]
    [Serializable]
    [XmlInclude(typeof(RealTimeDriver))]
    [XmlInclude(typeof(SimulationDriver))]

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