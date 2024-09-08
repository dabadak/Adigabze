using Adigabze.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adigabze.Data.DTO.Sozcuk
{
    public class SozcukDTO
    {
        public int SozcukId { get; set; }

        public int AnahtarId { get; set; }
        public string AnahtarSozcuk { get; set; }

        public string Anlam { get; set; }

        public SozcukTuru ENUMSozcukTuru { get; set; }
        public string SozcukTuru { get; set; }

        public int? ENUMYetkinlik { get; set; }
        public string Yetkinlik { get; set; }

        public int? KokId { get; set; }
        public string Kok { get; set; }
    }
}
