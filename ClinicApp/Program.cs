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

            int day = ReadInt("Day: ");
            
            int hour = ReadInt("Hour: ");

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