using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Adigabze.DAL.Entities
{
    public class Lehce
    {
        public int LehceId { get; set; }
        public string LehceAd { get; set; }

        public int DilId { get; set; }
        [ForeignKey("DilId")]
        public Dil Dil { get; set; }
    }
}
