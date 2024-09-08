using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Adigabze.Data.Abstract;
using Adigabze.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Adigabze.WebUI.Controllers
{
    public class KazanimController : Controller
    {
        private IKonuRepository _konuRepository;
        private IKazanimRepository _kazanimRepository;

        public KazanimController(IKazanimRepository kazanimRepository, IKonuRepository konuRepository)
        {
            _konuRepository = konuRepository;
            _kazanimRepository = kazanimRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return View(_kazanimRepository.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Konular = new SelectList(_konuRepository.GetAll(), "KonuId", "KonuTanim");

            return View();
        }

        [HttpPost]
        public IActionResult Create(Kazanim entity)
        {
            if(ModelState.IsValid)
            {
                _kazanimRepository.Add(entity);
                return RedirectToAction("List", "Kazanim");
            }
            return View(entity);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Konular = new SelectList(_konuRepository.GetAll(), "KonuId", "KonuTanim");

            return View(_kazanimRepository.Get(id));
        }

        [HttpPost]
        public IActionResult Update(Kazanim entity)
        {
            if(ModelState.IsValid)
            {
                _kazanimRepository.Update(entity);
                return RedirectToAction("List", "Kazanim");
            }

            return View(entity);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_kazanimRepository.Get(id));
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int KazanimId)
        {
            Kazanim kazanim = _kazanimRepository.Get(KazanimId);

            _kazanimRepository.Delete(kazanim);

            return RedirectToAction("List");
        }
    }
}