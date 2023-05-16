using System;
using BornToMove.Business;
using BornToMove.DAL;

namespace BornToMove
{
	public class kiezen
	{
        

        public List<Move> kiesActiviteit()
		{
            var context = new MoveContext();
            var buMove = new BuMove(context);


            Console.WriteLine("Hier is een lijst van beschikbare oefeningen: ");

            List<Move> exerciseList =  buMove.GetAllMoves();
            int exerciseNumber = 1;
            foreach (Move exercise in exerciseList)
            {
                Console.WriteLine($"{exerciseNumber}. {exercise.Name}, Intensiteit: {exercise.SweatRate}");
                exerciseNumber++;
            }
            return exerciseList;
        }
	}
}

