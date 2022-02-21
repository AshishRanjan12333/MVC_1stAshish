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
            List<Location> Location = DbContext.location.ToList();

            return View(Location);
        }
        public IActionResult CustomerList(int Id)
        {
            List<Customer> customers = DbContext.Customers.Where(e => e.LOCATION.ID == Id).ToList();
            return View(customers);
        }
    }
}
