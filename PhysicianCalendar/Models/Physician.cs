using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhysicianCalendar.Models
{
    public class Physician
    {
        internal static IEnumerable<string> doctors;

        public int Id { get; set; }
        public string Name { get; set; }
    }
}