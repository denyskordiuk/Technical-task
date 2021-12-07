using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Technical_task.Models;

namespace WebAPIApp.Models
{
    public class AccountContext : DbContext
{
        public DbSet<Account> Accounts { get; set; }
        public AccountContext(DbContextOptions<AccountContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}