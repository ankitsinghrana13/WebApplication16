using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication16.Models;

namespace WebApplication16.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext dbContext;
        public CustomerController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            List<Location> locations = dbContext.Locations.ToList();
            return View(locations);
        }
        public IActionResult CustomerList(int id)
        {
            List<Customer> customers = dbContext.Customers.Where(e => e.Location.Id == id).ToList();
            return View(customers);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
           dbContext.Employees.Add(emp);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        

        }
    }

