using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Training.UI.Controllers
{
    public class Module4Controller : Controller
    {
        public IActionResult Module()
        {
            return View("~/Views/Home/Module4/Module.cshtml");
        }
        public IActionResult Assignment1()
        {
            return View("~/Views/Home/Module4/Assignment1.cshtml");
        }
    }
}
