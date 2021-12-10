using Microsoft.EntityFrameworkCore;
using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Technical_task.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Nav
        public DbSet<Contact> Contacts { get; set; }
        public int IncidentId { get; set; }

    }
}
