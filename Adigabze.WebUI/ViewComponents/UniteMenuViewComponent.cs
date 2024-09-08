using Adigabze.Data.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adigabze.WebUI.ViewComponents
{
    public class UniteMenuViewComponent : ViewComponent
    {
        private IUniteRepository _repository;

        public UniteMenuViewComponent(IUniteRepository repository)
        {
            _repository = repository;
        }

        public IViewComponentResult Invoke()
        {
            return View(_repository.GetAll());
        }
    }
}
