using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NelsonCarsalesNetCore.CarsalesLib;
using NelsonCarsalesNetCore.Models;

namespace NelsonCarsalesNetCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
          
            return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}
