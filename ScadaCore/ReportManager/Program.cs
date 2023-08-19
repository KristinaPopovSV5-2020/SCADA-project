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
            List<ServiceReference1.Alarm> alarms = new List<ServiceReference1.Alarm>();
            List<ServiceReference1.Tag> tags = new List<ServiceReference1.Tag>();
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
                        Console.WriteLine(" All alarms that occurred within a specified time period");
                        DateTime startDate;
                        DateTime endDate;

                        while (true)
                        {
                            Console.Write("Enter start time (YYYY-MM-DD): ");

                            string startTime = Console.ReadLine();
                            startTime += " 00:00:00";

                            if (DateTime.TryParseExact(startTime, "yyyy-MM-dd HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out startDate))
                            {
                                break; // Prekidamo petlju ako je unos ispravan
                            }
                            else
                            {
                                Console.WriteLine("Invalid format.");
                            }
                        }

                        while (true)
                        {
                            Console.Write("Enter end time (YYYY-MM-DD): ");

                            string endTime = Console.ReadLine();
                            endTime += " 00:00:00";

                            if (DateTime.TryParseExact(endTime, "yyyy-MM-dd HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out endDate))
                            {
                                break; 
                            }
                            else
                            {
                                Console.WriteLine("Invalid format.");
                            }
                        }



                        

                        while (true)
                        {
                            Console.WriteLine("Sort by:");
                            Console.WriteLine("1. Time");
                            Console.WriteLine("2. Priority\n");
                            Console.Write("Enter an option: ");

                            string choiceopt1 = Console.ReadLine();

                            switch (choiceopt1)
                            {
                                case "1":
                                    alarms = service.alarmsSpecifiedTimePeriodSortByPriority(startDate, endDate);
                                    foreach (var a in alarms)
                                    {
                                        Console.WriteLine($"│{a.alarmId.PadRight(11)}│{a.tagId.PadRight(11)}│{a.time.ToString().PadRight(6)}│{a.type.ToString().PadRight(6)}|{a.limit.ToString().PadRight(6)}|{a.priority.ToString().PadRight(6)}|{a.tagValue.ToString().PadRight(6)}");
                                    }


                                    break;
                                case "2":
                                    break;

                                default:
                                    Console.WriteLine("Nevažeći unos. Molimo izaberite ponovo.");
                                    break;


                            }
                            break;

                        }
                        break;
                    case "2":
                        Console.WriteLine("All alarms of a certain priority");
                        // Dodajte funkcionalnost za opciju 2
                        break;
                    case "3":
                        Console.WriteLine("All tag values ​​that have reached the service in a certain time period");
                        // Dodajte funkcionalnost za opciju 3
                        break;
                    case "4":
                        Console.WriteLine("4.The last value of all AI tags");
                        return;
                    case "5":
                        Console.WriteLine("5. The last value of all DI tags");
                        return;
                    case "6":
                        Console.WriteLine("6. All tag values ​​with a specific identifier");
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
