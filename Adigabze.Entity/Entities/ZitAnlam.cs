using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Adigabze.DAL.Entities
{
    public class ZitAnlam
    {
        public int ZitAnlamId { get; set; }

        public int AnahtarId { get; set; }
        [ForeignKey("AnahtarId")]
        public Anahtar ZitAnlami { get; set; }

        public int SozcukId { get; set; }
        [ForeignKey("SozcukId")]
        public Sozcuk Sozcuk { get; set; }
    }
}
