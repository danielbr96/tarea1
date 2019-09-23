using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using tarea1.Models;

namespace tarea1.Controllers
{
    public class HomeController : Controller
    {
       public IActionResult Index()
        {
          
            var persona = new Models.Persona();
             return View(persona);
        }
        [HttpPost]
        public IActionResult Index(Models.Persona persona)
        {
            return View(persona);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
