using BornToMove.DAL;
using BornToMove;
using System.Collections.Generic;

namespace BornToMove.Business
{
    public class BuMove
    {
        private readonly MoveCrud _moveCrud;

        public BuMove(MoveContext context)
        {
            _moveCrud = new MoveCrud(context);
        }

        public Move GetMoveById(int id)
        {
            return _moveCrud.GetMoveById(id);
        }

        public List<Move> GetAllMoves()
        {
            return (List<Move>)_moveCrud.GetAllMoves();
        }

        public void CreateMove(string name, string description, string sweatRate)
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
    }
}
