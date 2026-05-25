using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Adigabze.DAL.Enums;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adigabze.DAL.Entities
{
    public class ImageEvaluation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Column(Order = 0)]
        public int ImageEvaluationId { get; set; }
        public Evaluation Evaluation { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

    }
}
