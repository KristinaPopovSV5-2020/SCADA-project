using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;

namespace Models
{
    public class AlarmManager
    {
        List<Alarm> alarms;
        string path;
        public AlarmManager(string path)
        {
            this.path = path;
            LoadAlarmsFromFile();
        }

        public Alarm findAlarm(string id)
        {
            return alarms.FirstOrDefault(alarm => alarm.AlarmId == id);

        }

        public List<Alarm> findAlarmsForTag(string tagName)
        {
            return alarms.Where(alarm => alarm.TagId == tagName).ToList();
        }

        public void LoadAlarmsFromFile()
        {
            alarms = new List<Alarm>();
            string[] lines = File.ReadAllLines(this.path + "/Database/alarms.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                string format = "yyyy-MM-dd HH:mm:ss";
                DateTime dateTime = DateTime.ParseExact(parts[2], format, CultureInfo.InvariantCulture);
                alarms.Add(new Alarm(parts[0], parts[1], dateTime, (TypeOfAlarm)Enum.Parse(typeof(TypeOfAlarm), parts[3]), double.Parse(parts[4]), parts[5], double.Parse(parts[6])));
            }
        }

        public void SaveAlarmsToFile()
        {
            using (StreamWriter writer = new StreamWriter(this.path + "/Database/alarms.txt"))
            {
                foreach (Alarm alarm in alarms)
                {
                    writer.WriteLine(alarm.AlarmId + "|" + alarm.TagId + "|" + alarm.Time.ToString() + "|" + alarm.Type + "|" + alarm.Limit + "|" + alarm.Priority + "|" + alarm.TagValue);
                }
            }
        }
    }
}