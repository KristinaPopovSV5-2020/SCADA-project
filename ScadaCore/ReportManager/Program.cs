using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportManager
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Choose a report:" + "/n");
                Console.WriteLine("1. All alarms that occurred within a specified time period");
                Console.WriteLine("2. All alarms of a certain priority");
                Console.WriteLine("3. Sve vrednosti tagova koje su dospele na servis u određenom vremenskom periodu");
                Console.WriteLine("4. Izlaz");
                Console.Write("Izaberite opciju: ");

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
                    default:
                        Console.WriteLine("Nevažeći unos. Molimo izaberite ponovo.");
                        break;
                }

                Console.WriteLine(); // Dodatni razmak za preglednost
            }
        }
    }
}
