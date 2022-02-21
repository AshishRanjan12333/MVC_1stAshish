using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace MVC_1stAshish.Models
{
    public class ApplicationDbContext :DbContext
    {
       public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Location>location { get; set; }
        public DbSet<Customer> Customers{ get; set; }

    }
}
