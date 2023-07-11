using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace AlarmDisplay
{

    public class Callback : ServiceReference1.IAlarmDisplayCallback
    {
       
        public void showAlarmDisplay(ServiceReference1.Alarm alarm)
        {
            Console.WriteLine(alarm.ToString());
            using (StreamWriter writer = File.AppendText("../Models/Database/alarms.txt"))
            {
                writer.WriteLine(alarm.ToString());
        }
    }
    class Program
    {
        static ServiceReference1.AlarmDisplayClient service;
        static void Main(string[] args)
        {

            InstanceContext ic = new InstanceContext(new Callback());
            service = new ServiceReference1.AlarmDisplayClient(ic);

            service.initializationAlarmDisplay();
            Console.ReadLine();
        }
    }
}
