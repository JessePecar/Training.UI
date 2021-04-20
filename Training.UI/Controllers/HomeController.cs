using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Training.UI.Models;

namespace Training.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Module2()
        {
            return View("~/Views/Home/Module2.cshtml");
        }

        public IActionResult Module3()
        {
            return View("~/Views/Home/Module3/Module.cshtml");
        }

        public IActionResult Assignment1()
        {
            return View("~/Views/Home/Assignment1.cshtml");
        }

        public IActionResult Assignment2()
        {
            return View("~/Views/Home/Assignment2.cshtml");
        }
        public IActionResult Assignment3()
        {
            return View("~/Views/Home/Assignment3.cshtml");
        }
        
        public IActionResult Assignment4()
        {
            return View("~/Views/Home/Assignment4.cshtml");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
