using Adigabze.DAL.Enums;
using Adigabze.Data.Abstract;
using Adigabze.Data.DTO.SEM;
using Adigabze.Data.DTO.Sozcuk;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            var sozcukDTO = _sozcukRepository.GetAll().Select(e => new SozcukDTO
            {
                SozcukId = e.SozcukId,
                AnahtarId = e.AnahtarId,
                AnahtarSozcuk = e.AnahtarSozcuk.ToString() ,
                Anlam = e.Anlam,
                ENUMSozcukTuru = e.SozcukTuru,
                SozcukTuru= e.SozcukTuru.ToString(),
                ENUMYetkinlik = e.YetkinlikID ,
                Yetkinlik = e.Yetkinlik.ToString() ,
                KokId = e.KokId,
                Kok = e.Kok.ToString(),

            }).ToList();

            return View(sozcukDTO);
        }
    }
}