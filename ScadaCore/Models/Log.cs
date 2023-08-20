using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [DataContract]
    public class Log
    {
        [DataMember]
        public string tagName;
        [DataMember]
        public double value;
        [DataMember]
        public DateTime dateTime;
        [DataMember]
        public string type;

        public Log()
        {
        }

        public Log(string tagName,double value,DateTime dateTime, string type)
        {
            this.tagName = tagName;
            this.value = value;
            this.dateTime = dateTime;
            this.type = type;
        }
    }
}
