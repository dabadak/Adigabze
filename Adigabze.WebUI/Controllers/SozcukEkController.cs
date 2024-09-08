using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Adigabze.DAL.Entities;
using Adigabze.DAL.Enums;
using Adigabze.Data.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Adigabze.WebUI.Controllers
{
    public class SozcukEkController : Controller
    {
        private ISozcukEkRepository _sozcukEkRep;

        public SozcukEkController(ISozcukEkRepository sozcukEkRep)
        {
            _sozcukEkRep = sozcukEkRep;
        }

        public IActionResult Index()
        {
            return View(_sozcukEkRep.GetAll());
        }

        public IActionResult Create()
        {
            SozcukEk sozcukEk = new SozcukEk();

            ViewBag.SozcukEkTipi = new SelectList(Enum.GetValues(typeof(SozcukEkTipi)), null);
            ViewBag.SozcukEkTuru = new SelectList(Enum.GetValues(typeof(SozcukEkTuru)), null);

            return View(sozcukEk);
        }
    }
}