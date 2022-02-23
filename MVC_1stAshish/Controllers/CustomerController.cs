using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_1stAshish.Models;
namespace MVC_1stAshish.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext DbContext;
        public CustomerController(ApplicationDbContext DbContext)
        {
            this.DbContext = DbContext;
        }
        public IActionResult Index()
        {
            List<Location> Location = DbContext.Locations.ToList();

            return View(Location);
        }
        public IActionResult CustomerList(int Id)
        {
            List<customer> customer = DbContext.customers.Where(e => e.Location.ID== Id).ToList();
            return View(customer);
        }
    }
}
