using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BornToMove;
using K4os.Compression.LZ4.Internal;

namespace BornToMove.DAL
{
    public class RatingsConverter : Comparer<MoveRating>
    {
        public override int Compare(MoveRating x, MoveRating y)
        {
            return y.Rating.CompareTo(x.Rating);
        }
    }
}

