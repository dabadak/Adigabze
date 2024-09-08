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
    public class AlfabeController : Controller
    {
        private IHarfRepository _repository;
        public AlfabeController(IHarfRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return View(_repository.GetAll());
        }

        public IActionResult Details(int id)
        {
            return View(_repository.Get(id));
        }
    }
}