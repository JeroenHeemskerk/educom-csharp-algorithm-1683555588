using System;
using System.Xml.Linq;
using BornToMove.DAL;
using System.ComponentModel.DataAnnotations.Schema;


namespace BornToMove
{
    [Table("move")]
    public class Move
    {
        private int? id = null;
        private string name = "";
        private string description = "";
        private int sweatRate;
        public ICollection<MoveRating> Rating { get; set; }


        public int? Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

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



