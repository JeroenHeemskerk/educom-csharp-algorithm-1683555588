

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BornToMove
{
    public class MoveRating
    {
        private int? id = null;
        private Move moveld;
        private double rating;
        private double vote;

        public int? Id
        {
            get { return id; }
            set { id = value; }
        }

      

        public double Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        public double Vote
        {
            get { return vote; }
            set { vote = value; }
        }

        public Move Moveld { get; set; }



    }
}