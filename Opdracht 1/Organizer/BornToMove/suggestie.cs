using System;
using BornToMove;
using BornToMove.Business;
using BornToMove.DAL;

namespace BornToMove
{
	public class suggestie
	{
		public Move suggestieMove()
		{
            var context = new MoveContext();
            var buMove = new BuMove(context);
            Random random = new Random();

            List<Move> exerciseList = buMove.GetAllMoves();
            int count = exerciseList.Count;
            int randomIndex = random.Next(count);
            Move randomMove = exerciseList[randomIndex];
            Console.WriteLine("Je volgende oefening is: {0}\n" +
                "Instructie: {1}.\n" +
                "Deze oefening heeft een intensiteitsniveau van: {2}",
                randomMove.Name, randomMove.Description, randomMove.SweatRate);

            return randomMove;
        }
    }
}

