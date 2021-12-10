using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Technical_task.Models
{
    public class Incident
    {
        public int Id { get; set; }
        public string NameIncident { get; set; }
        public string Description { get; set; }

        // Nav
        public DbSet<Account> Accounts { get; set; }
    }
}
