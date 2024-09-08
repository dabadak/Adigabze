using Adigabze.DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Adigabze.DAL.Entities
{
    public class Sozcuk
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Column(Order = 0)]
        public int SozcukId { get; set; }

        public int AnahtarId { get; set; }
        [ForeignKey("AnahtarId")]
        public Anahtar AnahtarSozcuk { get; set; }

        public string Anlam { get; set; }

        public SozcukTuru SozcukTuru { get; set; }

        public int? YetkinlikID { get; set; }
        [ForeignKey("YetkinlikID")]
        public Yetkinlik Yetkinlik { get; set; }

        public int? KokId { get; set; }
        [ForeignKey("KokId")]
        public Anahtar Kok { get; set; }

        //public int? KullanimId { get; set; }
        //[ForeignKey("KullanimId")]
        //public Kullanim Kullanimlar { get; set; }

        //public ICollection<EsAnlamAD> EsAnlam { get; set; } = new HashSet<EsAnlamAD>();
        //public ICollection<ZitAnlamAD> ZitAnlam { get; set; } = new HashSet<ZitAnlamAD>();

    }
}
