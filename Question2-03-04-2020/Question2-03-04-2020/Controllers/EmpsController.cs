using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Question2_03_04_2020.Models;

namespace Question2_03_04_2020.Controllers
{
    public class EmpsController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Employee";
            List<Emp> emplist = new List<Emp>()
            {
                new Emp{EId = 101, EName = "Sam",ESalary=30000 },
                new Emp{EId = 102, EName = "Sohan",ESalary=35000 },
                new Emp{EId = 103, EName = "Ram",ESalary=45550 },
                new Emp{EId = 104, EName = "Shyam",ESalary=98000 }
            };
            ViewBag.EmpData = emplist;
            return View();
        }
    }
}