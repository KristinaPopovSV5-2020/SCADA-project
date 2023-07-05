using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Models
{
    [DataContract]
    public class InputTag: Tag
    {

        [DataMember]
        private Driver driver;

        [DataMember]
        private int scanTime;


        [DataMember]
        private bool scan;

        public InputTag(): base()
        {
        }

        public InputTag(string id, string desc, string ioAddress, Driver driver, int scanTime, bool scan) : base(id, desc, ioAddress)
        {
            this.driver = driver;
            this.scanTime = scanTime;
            this.scan = scan;
        }

        public Driver Driver
        {
            get { return driver; }
            set { driver = value; }
        }

        public int ScanTime { get; set; }

        public bool Scan { get; set; }








    }
}