using System;
using System.Collections.Generic;
using System.Text;

namespace Adigabze.DAL.Entities
{
    public class Harf
    {
        public int HarfId { get; set; }
        public string BuyukHarf { get; set; }
        public string KucukHarf { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
        public string Image { get; set; }

        public int DilId { get; set; }
        public Dil Dil { get; set; }
    }
}
