using System;
using System.Collections.Generic;
using System.Text;

namespace Adigabze.DAL.Entities
{
    public class Sulale
    {
        public int SulaleId { get; set; }
        public string SulaleAdi { get; set; }

        public int BoyId { get; set; }
        public Boy Boy { get; set; }
    }
}
