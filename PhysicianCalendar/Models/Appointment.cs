using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhysicianCalendar.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public string PatientName { get; set; }
        public string PatientLastName { get; set; }
        public DateTime Time { get; set; }

        // Consider changing it to enum.
        public string Kind { get; set; }
    }
}