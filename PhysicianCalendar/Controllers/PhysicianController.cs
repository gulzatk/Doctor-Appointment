using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PhysicianCalendar.Models;

namespace PhysicianCalendar.Controllers
{
    public class PhysicianController : ApiController
    {
        // GET api/values
        public IEnumerable<Physician> Get()
        {
            return DataStore.physicians; ;
        }
    }
}
