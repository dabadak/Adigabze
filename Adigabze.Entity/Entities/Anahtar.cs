using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Adigabze.DAL.Entities
{
    public class Anahtar
    {
        public int AnahtarId { get; set; }
        public string Sozcuk { get; set; }

        public int MyProperty { get; set; }

    }
}
