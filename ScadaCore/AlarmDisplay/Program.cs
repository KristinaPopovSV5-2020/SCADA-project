﻿using System;
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
       
        public void showAlarmDisplay(Alarm alarm)
        {
            for( int i = 0; i < int.Parse(alarm.Priority); i++)
            {
                //ispisuje se onoliko puta za redom kog je prioriteta
                Console.WriteLine(alarm.ToString());

            }
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
