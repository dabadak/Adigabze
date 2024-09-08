using System;
using System.Collections.Generic;
using System.Text;

namespace Adigabze.DAL.Entities
{
    public class Unite
    {
        public int UniteId { get; set; }
        public string UniteTanim { get; set; }

        public int YetkinlikId { get; set; }
        public Yetkinlik Yetkinlik { get; set; }

        public List<Konu> Konular { get; set; }

    }
}
