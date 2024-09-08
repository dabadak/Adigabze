using System;
using System.Collections.Generic;
using System.Text;

namespace Adigabze.DAL.Entities
{
    public class Konu
    {
        public int KonuId { get; set; }
        public string KonuTanim { get; set; }

        public int UniteId { get; set; }
        public Unite Unite { get; set; }

        public List<Kazanim> Kazanimlar { get; set; }


    }
}
