using ClinicApp.Models;
using ClinicApp.Services;

namespace ClinicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppointmentManager manager = new AppointmentManager();

            while (true)
            {
                Console.WriteLine("=== Clinic App ===");
                Console.WriteLine("1. Add appointment.");
                Console.WriteLine("2. View appointments.");
                Console.WriteLine("3. Exit.");

                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                if (choice == "1")

                {
                    AddAppointmentFlow(manager);
                }
                else if (choice == "2")
                {
                    manager.ViewAppointments();
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Exiting...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option. Try again.");
                }
            }
        }
        static void AddAppointmentFlow(AppointmentManager manager)
        {
            
            string name = ReadRequiredString("Patient name: ");
            
            string phone = ReadRequiredString("Phone: ");
            
            string service = ReadRequiredString("Service: ");
            
            int year = ReadInt("Year: ");
            
            int month = ReadInt("Month: ");

<<<<<<< HEAD
            int day = ReadInt("Day: ");
            
            int hour = ReadInt("Hour: ");
=======
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Patient name cannot be empty.");
                return;
            }

            Console.Write("Patient phone: ");
            string phone = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(phone))
            {
                Console.WriteLine("Patient phone cannot be empty.");
                return;
            }

            Console.Write("Service: ");
            string service = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(service))
            {
                Console.WriteLine("Service cannot be empty.");
                return;
            }

            Console.Write("Year: ");
            if (!int.TryParse(Console.ReadLine(), out int year))
            {
                Console.WriteLine("Invalid input for year.");
                return;
            }

            Console.Write("Month: ");
           if (!int.TryParse(Console.ReadLine(), out int month))
            {
                Console.WriteLine("Invalid input for month.");
                return;
            }

            Console.Write("Day: ");
            if (!int.TryParse(Console.ReadLine(), out int day))
            {
                Console.WriteLine("Invalid input for day.");
                return;
            }

            Console.Write("Hour: ");
            if (!int.TryParse(Console.ReadLine(), out int hour))
            {
                Console.WriteLine("Invalid input for hour");
                return;
            }
>>>>>>> 4ec57509cb9cea6074a9f446b7c8ed1d6bb3b2b4

            Patient patient = new Patient
            {
                Name = name,
                Phone = phone
            };


            Appointment appointment = new Appointment
            {
                Patient = patient,
                Service = service,
                Time = new DateTime(year, month, day, hour, 0, 0)
            };
            manager.AddAppointment(appointment);
            Console.WriteLine("Appointment aded successfully.");
        }
        static string ReadRequiredString(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("Input cannot be empty.");
                }
            }
        }
        static int ReadInt(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();
                if (int.TryParse(input, out int result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Invalid number. Try again.");
                }
            }
        }
    }
}