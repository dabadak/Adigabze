using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Adigabze.DAL.Entities
{
    public class EsAnlam
    {
        public int EsAnlamId { get; set; }

        public int AnahtarId { get; set; }
        [ForeignKey("AnahtarId")]
        public Anahtar EsAnlami { get; set; }

        public int SozcukId { get; set; }
        [ForeignKey("SozcukId")]
        public Sozcuk Sozcuk { get; set; }
    }
}
