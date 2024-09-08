using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Adigabze.Data.Abstract;
using Adigabze.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Adigabze.WebUI.Controllers
{
    public class UniteController : Controller
    {
        private IUniteRepository _repository;

        public UniteController(IUniteRepository repository)
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

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Unite entity)
        {
            return View();
        }
    }
}