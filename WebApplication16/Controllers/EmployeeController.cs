using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication16.Models;
namespace WebApplication16.Controllers
{
    public class EmployeeController : Controller
    {
        private ApplicationDbContext dbContext;
            public EmployeeController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            List<Employee> Employees = dbContext.Employees.ToList();
            return View(Employees);
        }
    }
}
