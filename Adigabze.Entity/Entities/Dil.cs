using System;
using System.Collections.Generic;
using System.Text;

namespace Adigabze.DAL.Entities
{
    public class Dil
    {
        public int DilId { get; set; }
        public string DilAd { get; set; }

        public List<Harf> Alfabe { get; set; }

        public List<Lehce> Lehceler { get; set; }
    }
}
