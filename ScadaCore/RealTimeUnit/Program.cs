using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ScadaCore;

namespace RealTimeUnit
{
    class Program
    {
        public const int low_limit = 10;
        public const int high_limit = 100;

        static ServiceReference1.RTUClient service = new ServiceReference1.RTUClient();

        static void Main(string[] args)
        {
            string address = "";
            Random random = new Random();
            try
            {
                bool isConnected = false;
                

                while (!isConnected)
                {
                    Console.WriteLine("Enter the serial number of the address you want to connect to: ");
                    address = "address" + Console.ReadLine();

                    isConnected = service.addAddress(address);

                    if (!isConnected)
                    {
                        Console.WriteLine("Address not available. Available addresses are: ");
                        foreach(string a in service.getAvailableAddresses())
                        {
                            Console.WriteLine(a + "\n");
                        }

                    }
                }

                Console.WriteLine("You have successfully connected to the address!");
            }
            catch (FaultException e)
            {
                Console.WriteLine(e.GetBaseException());
                Console.ReadKey();
                return;
            }

            while (true)
            {

                double randomNumber = random.NextDouble() * (high_limit - low_limit )+ low_limit;

                Console.WriteLine("Sending " + randomNumber + "from RTU to Service on address " + address);
                service.sendToService(address, randomNumber);

                Thread.Sleep(3000);
            }



        }
    }
}
