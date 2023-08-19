using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReportManager
{
    class Program
    {
        static ServiceReference1.ReportManagerClient service = new ServiceReference1.ReportManagerClient();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose a report:");
                Console.WriteLine("");
                Console.WriteLine("1. All alarms that occurred within a specified time period");
                Console.WriteLine("2. All alarms of a certain priority");
                Console.WriteLine("3. All tag values ​​that have reached the service in a certain time period");
                Console.WriteLine("4. The last value of all AI tags");
                Console.WriteLine("5. The last value of all DI tags");
                Console.WriteLine("6. All tag values ​​with a specific identifier" + "\n");

                Console.Write("Enter an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Izabrali ste opciju 1.");
                        // Dodajte funkcionalnost za opciju 1
                        break;
                    case "2":
                        Console.WriteLine("Izabrali ste opciju 2.");
                        // Dodajte funkcionalnost za opciju 2
                        break;
                    case "3":
                        Console.WriteLine("Izabrali ste opciju 3.");
                        // Dodajte funkcionalnost za opciju 3
                        break;
                    case "4":
                        Console.WriteLine("Izlaz iz programa.");
                        return;
                    case "5":
                        Console.WriteLine("Izlaz iz programa.");
                        return;
                    case "6":
                        Console.WriteLine("Izlaz iz programa.");
                        return;
                    default:
                        Console.WriteLine("Nevažeći unos. Molimo izaberite ponovo.");
                        break;
                }

                Console.WriteLine(); // Dodatni razmak za preglednost
            }
        }
    }
}
