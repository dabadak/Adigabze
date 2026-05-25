using Adigabze.DAL.Enums;
using Adigabze.Data.Abstract;
using Adigabze.Data.Concrete.EFCore;
using Adigabze.Data.DTO.SEM;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adigabze.WebUI.Controllers
{
    public class ParentController : Controller
    {
        private readonly IParentRepository _repository;

        // Ensure you are using the Interface type here
        public ParentController(IParentRepository repository)
        {
            _repository = repository;
        }

        public IActionResult List()
        {
            var parentDTO= _repository.GetAll().Select(d => new ParentDTO
            {
                ParentId = d.ParentId,
                FileName = d.FileName,
                Description = d.Description,
                Magnitute = d.Magnitute,
                Scale = d.Scale,
                FileNameO = d.FileNameO,
                ENUMEvaluation = (Evaluation)d.Evaluation,

            }).ToList();

            return View(parentDTO);
        }
    }
}
