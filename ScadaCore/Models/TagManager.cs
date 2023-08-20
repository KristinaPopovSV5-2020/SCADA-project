using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Models
{
    public class TagManager
    {
        public Dictionary<string, Tag> tags = new Dictionary<string, Tag>();
        public AlarmManager alarmManager;
        string path;


        public TagManager()
        {

        }

        public TagManager(AlarmManager alarmManager, string path)
        {
            this.path = path;
            this.alarmManager = alarmManager;
            LoadAIFromFile();
            LoadAOFromFile();
            LoadDIFromFile();
            LoadDOFromFile();
        }

        public void LoadDIFromFile()
        {
            string[] lines = File.ReadAllLines(this.path + "/Database/digitalInputTags.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                tags.Add(parts[0], new DigitalInput(parts[0], parts[1], parts[2], new Driver(), int.Parse(parts[4]), bool.Parse(parts[5]), double.Parse(parts[6])));
            }
        }

        public void LoadDOFromFile()
        {
            string[] lines = File.ReadAllLines(this.path + "/Database/digitalOutputTags.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                tags.Add(parts[0], new DigitalOutput(parts[0], parts[1], parts[2], double.Parse(parts[3])));
            }
        }

        public void LoadAIFromFile()
        {
            string[] lines = File.ReadAllLines(this.path + "/Database/analogInputTags.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                tags.Add(parts[0], new AnalogInput(parts[0], parts[1], parts[2], new Driver(), int.Parse(parts[4]), bool.Parse(parts[5]), alarmManager.findAlarmsForTag(parts[0]), double.Parse(parts[6]), double.Parse(parts[7]), parts[8], double.Parse(parts[9])));
            }
        }

        public void LoadAOFromFile()
        {
            string[] lines = File.ReadAllLines(this.path + "/Database/analogOutputTags.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                tags.Add(parts[0], new AnalogOutput(parts[0], parts[1], parts[2], double.Parse(parts[3]), int.Parse(parts[4]), double.Parse(parts[5]), parts[6]));
            }
        }

        public void SaveTagsToFiles()
        {
            foreach (KeyValuePair<string, Tag> t in tags)
            {
                Tag tag = t.Value;
                if (tag is DigitalInput)
                {
                    DigitalInput diTag = tag as DigitalInput;
                    using (StreamWriter writer = File.AppendText(this.path + "/Database/digitalInputTags.txt"))
                    {
                        writer.WriteLine(diTag.TagName + "|" + diTag.Description + "|" + diTag.Driver.Id + "|" + diTag.IOAddress + "|" + diTag.ScanTime + "|" + diTag.Scan + "|" + diTag.InitialValue);
                    }
                }
                else if (tag is DigitalOutput)
                {
                    DigitalOutput doTag = tag as DigitalOutput;
                    using (StreamWriter writer = File.AppendText(this.path + "/Database/digitalOutputTags.txt"))
                    {
                        writer.WriteLine(doTag.TagName + "|" + doTag.Description + "|" + doTag.IOAddress + "|" + doTag.InitialValue);
                    }
                }
                else if (tag is AnalogInput)
                {
                    AnalogInput aiTag = tag as AnalogInput;
                    using (StreamWriter writer = File.AppendText(this.path + "/Database/analogInputTags.txt"))
                    {
                        writer.WriteLine(aiTag.TagName + "|" + aiTag.Description + "|" + aiTag.Driver.Id + "|" + aiTag.IOAddress + "|" + aiTag.ScanTime + "|" + aiTag.Scan + "|" + aiTag.LowLimit + "|" + aiTag.HighLimit + "|" + aiTag.Units + "|" + aiTag.InitialValue);
                    }
                }
                else if (tag is AnalogOutput)
                {
                    AnalogOutput aoTag = tag as AnalogOutput;
                    using (StreamWriter writer = File.AppendText(this.path + "/Database/analogOutputTags.txt"))
                    {
                        writer.WriteLine(aoTag.TagName + "|" + aoTag.Description + "|" + aoTag.IOAddress + "|" + aoTag.InitialValue + "|" + aoTag.LowLimit + "|" + aoTag.HighLimit + "|" + aoTag.Units);
                    }
                }
            }
        }

        public void SaveNewTagToFile(Tag tag)
        {
            if (tag is DigitalInput)
            {
                DigitalInput diTag = tag as DigitalInput;
                using (StreamWriter writer = File.AppendText(this.path + "/Database/digitalInputTags.txt"))
                {
                    writer.WriteLine(diTag.TagName + "|" + diTag.Description + "|" + diTag.Driver.Id + "|" + diTag.IOAddress + "|" + diTag.ScanTime + "|" + diTag.Scan + "|" + diTag.InitialValue);
                }
            }
            else if (tag is DigitalOutput)
            {
                DigitalOutput doTag = tag as DigitalOutput;
                using (StreamWriter writer = File.AppendText(this.path + "/Database/digitalOutputTags.txt"))
                {
                    writer.WriteLine(doTag.TagName + "|" + doTag.Description + "|" + doTag.IOAddress + "|" + doTag.InitialValue);
                }
            }
            else if (tag is AnalogInput)
            {
                AnalogInput aiTag = tag as AnalogInput;
                using (StreamWriter writer = File.AppendText(this.path + "/Database/analogInputTags.txt"))
                {
                    writer.WriteLine(aiTag.TagName + "|" + aiTag.Description + "|" + aiTag.Driver.Id + "|" + aiTag.IOAddress + "|" + aiTag.ScanTime + "|" + aiTag.Scan + "|" + aiTag.LowLimit + "|" + aiTag.HighLimit + "|" + aiTag.Units + "|" + aiTag.InitialValue);
                }
            }
            else if (tag is AnalogOutput)
            {
                AnalogOutput aoTag = tag as AnalogOutput;
                using (StreamWriter writer = File.AppendText(this.path + "/Database/analogOutputTags.txt"))
                {
                    writer.WriteLine(aoTag.TagName + "|" + aoTag.Description + "|" + aoTag.IOAddress + "|" + aoTag.InitialValue + "|" + aoTag.LowLimit + "|" + aoTag.HighLimit + "|" + aoTag.Units);
                }
            }
        }


    }

}