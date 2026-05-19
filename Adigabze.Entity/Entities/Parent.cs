using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adigabze.DAL.Entities
{
    public class Parent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Column(Order = 0)]
        public int ParentId { get; set; }

        public string FileName { get; set; }
        public string Description { get; set; }
        public int Magnitute { get; set; }
        public int Scale { get; set; }
        public byte Evaluation { get; set; }
        public string FileNameO { get; set; }

    }
}
