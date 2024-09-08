using System;
using System.Collections.Generic;
using System.Text;

namespace Adigabze.DAL.Entities
{
    public class Boy
    {
        public int BoyId { get; set; }
        public string BoyAdi { get; set; }

        public int DilId { get; set; }
        public Dil Dil { get; set; }

        public List<Sulale> Sulaleler { get; set; }
    }
}
