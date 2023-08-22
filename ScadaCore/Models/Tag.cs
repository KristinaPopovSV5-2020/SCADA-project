using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace Models
{
    [DataContract]
    [XmlInclude(typeof(AnalogInput))]
    [XmlInclude(typeof(AnalogOutput))]
    [XmlInclude(typeof(DigitalInput))]
    [XmlInclude(typeof(DigitalOutput))]
    [XmlInclude(typeof(InputTag))]
    [XmlInclude(typeof(OutputTag))]
    [KnownType(typeof(InputTag))]
    [KnownType(typeof(OutputTag))]
    [KnownType(typeof(DigitalInput))]
    [KnownType(typeof(DigitalOutput))]
    [KnownType(typeof(AnalogInput))]
    [KnownType(typeof(AnalogOutput))]
    public class Tag
    {

        [DataMember]
        private string tagName;

        [DataMember]
        private string description;

        [DataMember]
        private string ioAddress;

        [DataMember]
        private double initialValue;

        public Tag() { }

        public Tag(string id) { tagName = id; }

        public Tag(string id, string desc, string address, double v)
        {
            tagName = id;
            description = desc;
            ioAddress = address;
            initialValue = v;
        }


        public string TagName
        {
            get { return tagName; }
            set { tagName = value; }
        }


        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string IOAddress
        {
            get { return ioAddress; }
            set { ioAddress = value; }
        }

        public double InitialValue
        {
            get { return initialValue; }
            set { initialValue = value; }
        }



        public override string ToString()
        {
            return string.Format("Tag name: " + tagName + " Description: " + description + " IOAddress: " + ioAddress + "Initial value: " + initialValue);
        }






    }
}