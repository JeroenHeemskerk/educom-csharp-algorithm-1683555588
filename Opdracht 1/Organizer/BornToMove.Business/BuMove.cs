using BornToMove.DAL;
using BornToMove;
using System.Collections.Generic;
using System.Linq;

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

        public (List<Move> moves, List<double> averageRatings) GetAllMovesWithAverageRating()
        {
            List<Move> moves = _moveCrud.GetAllMoves();

            List<double> averageRatings = moves.Select(move =>
            {
                var moveRatings = _moveRatingCrud.GetAllMoveRatings()
                    .Where(rating => rating.MoveId == move.Id)
                    .ToList();

                double averageRating = moveRatings.Any()
                    ? moveRatings.Average(rating => rating.Rating)
                    : 0;

                return averageRating;
            }).ToList();

            return (moves, averageRatings);
        }




    }
}
