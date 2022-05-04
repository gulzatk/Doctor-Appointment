using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhysicianCalendar.Models
{
    public class DataStore
    {
        public static List<Physician> physicians = new List<Physician>() {
            new Physician { Id = 1, Name = "Hibbert, Julius" },
            new Physician { Id = 2, Name = "Krieger, Algernop"},
            new Physician { Id = 3, Name = "Riviera Nick"},
        };

        public static Dictionary<int, List<Appointment>> physicianAppointments = new Dictionary<int, List<Appointment>>();

        public static Dictionary<int, Appointment> appointmentsById = new Dictionary<int, Appointment>();

        public static void AddAppointment(int physicianId, Appointment app)
        {
            if (!physicianAppointments.ContainsKey(physicianId))
            {
                physicianAppointments[physicianId] = new List<Appointment>();
            }

            appointmentsById[app.Id] = app;
            physicianAppointments[physicianId].Add(app);
        }
    }
}