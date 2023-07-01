using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ScadaModel
{
    [DataContract]
    public class Tag
    {

        [DataMember]
        private string tagName;

        [DataMember]
        private string description;

        [DataMember]
        private string ioAddress;

        public Tag() { }

        public Tag(string id) { tagName = id; }

        public Tag(string id, string desc, string address)
        {
            tagName = id;
            description = desc;
            ioAddress = address;
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



        public override string ToString()
        {
            return string.Format("Tag name: " + tagName + " Description: " + description + " IOAddress: " + ioAddress);
        }






    }
}