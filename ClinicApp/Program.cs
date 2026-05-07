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
            Console.Write("Patient name: ");
            string name = Console.ReadLine();

            Console.Write("Patient phone: ");
            string phone = Console.ReadLine();

            Console.Write("Service: ");
            string service = Console.ReadLine();

            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Month: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Day: ");
            int day = int.Parse(Console.ReadLine());

            Console.Write("Hour: ");
            int hour = int.Parse(Console.ReadLine());

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
    }
}
