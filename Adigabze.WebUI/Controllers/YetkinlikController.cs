using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Adigabze.WebUI.Controllers
{
    public class YetkinlikController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}