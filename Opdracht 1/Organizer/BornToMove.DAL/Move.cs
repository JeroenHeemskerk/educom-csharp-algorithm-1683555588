using System;
using System.Xml.Linq;
using BornToMove.DAL;
using System.ComponentModel.DataAnnotations.Schema;


namespace BornToMove
{
    [Table("move")]
    public class Move
    {
        private string description = "";
        private int sweatRate;
        public ICollection<MoveRating> Rating { get; set; }

        public int? Id { get; set; } = null;

        public string Name { get; set; } = "";

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int SweatRate
        {
            get { return sweatRate; }
            set { sweatRate = value; }
        }

    }
}



