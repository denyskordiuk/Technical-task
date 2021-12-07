using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Technical_task.Models
{
    public class Incident
    {
        public int IncidentId { get; set; }
        public string NameIncident { get; set; }
        public string Description { get; set; }
        public int AccId { get; set; }
    }
}
