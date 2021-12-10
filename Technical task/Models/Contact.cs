using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Technical_task.Models
{
    public class Contact
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Unique]
        public string Email { get; set; }

        // Nav
        public int AccountId { get; set; }
        public Account Account { get; set; }

    }
}
