using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Models
{
    public enum TypeOfAlarm
    {
        Low,
        Med,
        High
    }

    [DataContract]
    public class Alarm
    {
        [DataMember]
        string alarmId;


        [DataMember]
        private string tagId;

        [DataMember]
        DateTime time;

        [DataMember]
        TypeOfAlarm type;

        [DataMember]
        double limit;

        [DataMember]
        string priority;


        [DataMember]
        double tagValue;


        public Alarm() { }

        public Alarm(string alarmId, string tagId, DateTime time, TypeOfAlarm type, double limit, string priority, double tagValue)
        {
            this.alarmId = alarmId;
            this.tagId = tagId;
            this.time = time;
            this.type = type;
            this.limit = limit;
            this.priority = priority;
            this.tagValue = tagValue;
        }

        public Alarm(string alarmId, string tagId, TypeOfAlarm type, double limit, string priority)
        {
            this.alarmId = alarmId;
            this.tagId = tagId;
            this.type = type;
            this.limit = limit;
            this.priority = priority;
        }

        public override string ToString()
        {
            return "Alarm name: " + AlarmId + ",Tag: " + TagId + ",Time: " + Time.ToString() + ",Type: " + Type.ToString() + ",Limit: " + Limit + ",TagValue: " + TagValue;
        }


        public string AlarmId
        {
            get { return alarmId; }
            set { alarmId = value; }
        }




        public string TagId
        {
            get { return tagId; }
            set { tagId = value; }
        }

        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }


        public TypeOfAlarm Type
        {
            get { return type; }
            set { type = value; }
        }

        public double Limit
        {
            get { return limit; }
            set { limit = value; }
        }

        public string Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        public double TagValue
        {
            get { return tagValue; }
            set { tagValue = value; }
        }

        


    }
}
