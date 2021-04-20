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
    public class Module3Controller: Controller
    {
        private readonly ILogger<Module3Controller> _logger;

        public Module3Controller(ILogger<Module3Controller> logger)
        {
            _logger = logger;
        }

        public IActionResult Assignment1()
        {
            return View("~/Views/Home/Module3/Assignment1.cshtml");
        }

        public IActionResult Assignment2()
        {
            return View("~/Views/Home/Module3/Assignment2.cshtml");
        }
        public IActionResult Assignment3()
        {
            return View("~/Views/Home/Module3/Assignment3.cshtml");
        }
        
        public IActionResult Assignment4()
        {
            return View("~/Views/Home/Module3/Assignment4.cshtml");
        }
    }
}
