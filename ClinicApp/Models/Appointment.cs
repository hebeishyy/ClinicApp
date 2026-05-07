using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Models
{
    public class Appointment
    {
        public DateTime Time { get; set; }
        public Patient Patient { get; set; }
        public string Service { get; set; }
        public bool IsCancelled { get; set; }
    }
}
