using System;
using System.Collections.Generic;
using System.Text;

namespace Adigabze.DAL.Entities
{
    public class Yetkinlik
    {
        public int YetkinlikId { get; set; }
        public string YetkinlikTanim { get; set; }

        public List<Unite> Uniteler { get; set; }

    }
}
