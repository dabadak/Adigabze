using System;
using System.Collections.Generic;
using System.Text;

namespace Adigabze.DAL.Entities
{
    public class Kazanim
    {
        public int KazanimId { get; set; }
        public string KazanimTanim { get; set; }

        public string Aciklama { get; set; }

        public int KonuId { get; set; }
        public Konu Konu { get; set; }


    }
}
