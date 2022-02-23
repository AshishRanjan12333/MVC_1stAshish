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
        public DbSet<Location>Locations { get; set; }
       public DbSet<customer> customers{ get; set; }
        public DbSet<Employee> employees { get; set; }

    }
}
                                                                                                