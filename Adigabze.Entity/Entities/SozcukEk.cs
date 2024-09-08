using Adigabze.DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Adigabze.DAL.Entities
{
    public class SozcukEk
    {
        public int SozcukEkId { get; set; }

        public SozcukEkTipi EkTipi { get; set; }
        public SozcukEkTuru EkTuru { get; set; }
        public string Ek { get; set; }
        public string Tanim { get; set; }

        public int? UstId { get; set; }
        [ForeignKey("UstId")]
        public SozcukEk Temel { get; set; }
    }
}
