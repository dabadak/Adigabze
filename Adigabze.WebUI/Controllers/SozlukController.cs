using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Adigabze.Data.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Adigabze.WebUI.Controllers
{
    public class SozlukController : Controller
    {
        private ISozcukRepository _sozcukRepository;

        public SozlukController(ISozcukRepository sozcukRepository)
        {
            _sozcukRepository = sozcukRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }
    }
}