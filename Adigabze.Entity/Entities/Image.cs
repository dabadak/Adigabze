using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adigabze.DAL.Entities
{
    public class Image
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Column(Order = 0)]
        public int ImageId { get; set; }
        public byte Evaluation { get; set; }
        public int ParentId { get; set; }
        public Parent Parent { get; set; }

    }
}
