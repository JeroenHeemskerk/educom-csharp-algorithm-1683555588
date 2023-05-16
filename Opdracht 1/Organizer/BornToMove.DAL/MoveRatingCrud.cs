using BornToMove.DAL;
using Microsoft.EntityFrameworkCore;

namespace BornToMove.DAL
{
    public class MoveRatingCrud
    {
        private readonly MoveContext _context;

        public MoveRatingCrud(MoveContext context)
        {
            _context = context;
        }

        public void CreateMoveRating(MoveRating moveRating)
        {
            _context.MoveRating.Add(moveRating);
            _context.SaveChanges();
        }

        public void UpdateMoveRating(MoveRating moveRating)
        {
            _context.MoveRating.Update(moveRating);
            _context.SaveChanges();
        }

        public void DeleteMoveRating(int id)
        {
            var moveRating = _context.MoveRating.Find(id);
            _context.MoveRating.Remove(moveRating);
            _context.SaveChanges();
        }

        public MoveRating GetMoveRatingById(int id)
        {
            return _context.MoveRating.Find(id);
        }

        public List<MoveRating> GetAllMoveRatings()
        {
            return _context.MoveRating.Include(mr => mr.Moveld).ToList();
        }
    }
}
