using BornToMove.DAL;
using BornToMove;
using System.Collections.Generic;

namespace BornToMove.Business
{
    public class BuMoveRating
    {
        private readonly MoveRatingCrud _moveRatingCrud;

        public BuMoveRating(MoveContext context)
        {
            _moveRatingCrud = new MoveRatingCrud(context);
        }

        public MoveRating GetMoveRatingById(int id)
        {
            return _moveRatingCrud.GetMoveRatingById(id);
        }

        public List<MoveRating> GetAllMoveRatings()
        {
            return _moveRatingCrud.GetAllMoveRatings();
        }

        public void CreateMoveRating(Move move, double rating, double vote)
        {
            var moveRating = new MoveRating { MoveId = move.Id, Rating = rating, Vote = vote };
            _moveRatingCrud.CreateMoveRating(moveRating);
        }


        public void UpdateMoveRating(MoveRating moveRating)
        {
            _moveRatingCrud.UpdateMoveRating(moveRating);
        }

        public void DeleteMoveRating(int id)
        {
            _moveRatingCrud.DeleteMoveRating(id);
        }
    }
}
