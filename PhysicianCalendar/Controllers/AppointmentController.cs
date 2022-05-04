using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PhysicianCalendar.Models;

namespace PhysicianCalendar.Controllers
{
    public class AppointmentController : ApiController
    {
        // GET api/values/5
        [Route("appointentbyphysician/{physicianId}")]
        public IEnumerable<Appointment> GetByPhysician(int physicianId)
        {
            return DataStore.physicianAppointments[1];
        }

        public Appointment Get(int id)
        {
            return DataStore.appointmentsById[id] ?? null;
        }
    }
}
