using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Adigabze.Data.Abstract;
using Adigabze.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Adigabze.WebUI.Controllers
{
    public class HomeController : Controller
    {
        //private IYetkinlikRepository yetkinlikRepository;
        //private IUniteRepository uniteRepository;

        public HomeController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}