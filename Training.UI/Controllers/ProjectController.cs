using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Training.UI.Models;

namespace Training.UI.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult MonsterSlayer()
        {
            return View("~/Views/Projects/MonsterSlayer.cshtml", new MonsterSlayerViewModel());
        }
    }
}
