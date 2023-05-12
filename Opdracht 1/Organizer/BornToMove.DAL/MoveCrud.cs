
using System;
using System.Collections.Generic;
using System.Linq;
using BornToMove;

namespace BornToMove.DAL

{
    public class MoveCrud
    {
        private readonly MoveContext _context;

        public MoveCrud(MoveContext context)
        {
            _context = context;
        }

        public void CreateMove(Move move)
        {
            _context.Moves.Add(move);
            _context.SaveChanges();
        }

        public void UpdateMove(Move move)
        {
            _context.Moves.Update(move);
            _context.SaveChanges();
        }

        public void DeleteMove(int id)
        {
            var move = _context.Moves.Find(id);
            _context.Moves.Remove(move);
            _context.SaveChanges();
        }

        public Move GetMoveById(int id)
        {
            return _context.Moves.Find(id);
        }

        public IEnumerable<Move> GetAllMoves()
        {
            return _context.Moves.ToList();
        }
    }
}
