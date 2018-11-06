using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NelsonCarsalesNetCore.CarsalesLib;
using NelsonCarsalesNetCore.Models;


namespace NelsonCarsalesNetCore.Controllers
{
    public class CarController : Controller
    {
        [HttpGet, Produces("application/json")]
        public async Task<IActionResult> GetCar()
        {
            ApiCaller MyApi = new ApiCaller();
            var data = await MyApi.ApiCar();
            return Json(new { result = data });

        }
    }
}