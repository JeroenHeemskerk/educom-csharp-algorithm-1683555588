using BornToMove.DAL;
using Organizer;
using BornToMove;
using System.Collections.Generic;
using System.Linq;
using Org.BouncyCastle.Crypto.Tls;

namespace BornToMove.Business
{
    public class BuMove
    {
        private readonly MoveCrud _moveCrud;
        private readonly MoveRatingCrud _moveRatingCrud;

        public BuMove(MoveContext context)
        {
            _moveCrud = new MoveCrud(context);
            _moveRatingCrud = new MoveRatingCrud(context); // Instantiate the MoveRatingCrud object here

        }

        public Move GetMoveById(int id)
        {
            return _moveCrud.GetMoveById(id);
        }

        public Move GetMoveByName (string name)
        {
            return _moveCrud.GetMoveByName(name);
        }

        public List<Move> GetAllMoves()
        {
            return (List<Move>)_moveCrud.GetAllMoves();
        }

        public void CreateMove(string name, string description, int sweatRate)
        {
            var move = new Move { Name = name, Description = description, SweatRate = sweatRate };
            _moveCrud.CreateMove(move);
        }

        public void UpdateMove(Move move)
        {
            _moveCrud.UpdateMove(move);
        }

        public void DeleteMove(int id)
        {
            _moveCrud.DeleteMove(id);
        }



        public (Move move, double averageRating) GetMoveWithAverageRating(int moveId)
        {
            Move move = _moveCrud.GetMoveById(moveId);
            double averageRating = _moveRatingCrud.GetAllMoveRatings()
                .Where(rating => rating.MoveId == moveId)
                .Average(rating => rating.Rating);

            return (move, averageRating);
        }

        public List<MoveRating> GetAllMovesWithAverageRating()
        {
            List<Move> moves = _moveCrud.GetAllMoves();
            List<MoveRating> averageRatings = moves.Select(move =>
            {
                var moveRatingsForMove = move.Rating;

                double averageRating = moveRatingsForMove.Any()
                    ? moveRatingsForMove.Average(rating => rating.Rating)
                    : 0;
                int averageRatingInt = (int)Math.Round(averageRating);

                return new MoveRating() { Move = move, Rating = averageRatingInt };
            }).ToList();


            var rotateSort = new RotateSort<MoveRating>();
            var comparer = new RatingsConverter();

            rotateSort.Sort(averageRatings, comparer);

            return averageRatings;
        }

    }
}

