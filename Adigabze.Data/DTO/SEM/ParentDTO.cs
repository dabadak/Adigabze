using Adigabze.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adigabze.Data.DTO.SEM
{
    public class ParentDTO
    {
        public int ParentId { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public int Magnitute { get; set; }
        public int Scale { get; set; }
        public Evaluation ENUMEvaluation { get; set; }
        public string Evaluation { get; set; }
        public string FileNameO { get; set; }

    }
}
