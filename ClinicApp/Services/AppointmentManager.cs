using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicApp.Models;

namespace ClinicApp.Services
{
    public class AppointmentManager
    {
        private List<Appointment> appointments = new List<Appointment>();
        public void AddAppointment(Appointment appointment)
        {
            appointments.Add(appointment);
        }
        public void ViewAppointments()
        {
            foreach (Appointment appointment in appointments)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine(appointment.Patient.Name);
                Console.WriteLine(appointment.Patient.Phone);
                Console.WriteLine(appointment.Service);
                Console.WriteLine(appointment.Time);

            }
        }

    }
}
