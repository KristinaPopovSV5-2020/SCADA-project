using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Models;
using ScadaCore;

namespace RealTimeUnit
{
    class Program
    {
        static ServiceReference1.RTUClient service = new ServiceReference1.RTUClient();
 

        static void Main(string[] args)
        {
            string address = "";
            Random random = new Random();
            List<string> addresses = service.getAvailableAddresses();

            while (true)
            {
                int randomNumberAdd = random.Next(0, addresses.Count);
                address = addresses[randomNumberAdd];

                double randomNumber = 0;

                Tag tag = service.GetTagForAddress(address);
                if (tag is AnalogInput)
                    randomNumber = random.NextDouble() * (((AnalogInput)tag).HighLimit - ((AnalogInput)tag).LowLimit) + ((AnalogInput)tag).LowLimit;
                else
                    randomNumber = random.Next(0, 2);
                Console.WriteLine("Sending " + randomNumber + " from RTU to Service on address " + address);
                service.sendToService(address, randomNumber);

                Thread.Sleep(5000);
            }




        }

       
    }
}
