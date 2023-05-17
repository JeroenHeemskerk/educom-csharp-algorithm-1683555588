using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BornToMove
{
    [Table("MoveRating")]
    public class MoveRating
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }

        public double Rating { get; set; }

        public double Vote { get; set; }

        [ForeignKey("Move")]
        public int? MoveId { get; set; }

        public Move Move { get; set; } // Navigation property for the related Move entity
    }
}
