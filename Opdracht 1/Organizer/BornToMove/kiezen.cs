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

            var result = buMove.GetAllMovesWithAverageRating();
             

            int exerciseNumber = 1;
            foreach (MoveRating exercise in result)

            {
                Console.WriteLine($"{exerciseNumber}. {exercise.Move.Name}, intensiteit: {exercise.Move.SweatRate}, gemiddelde waardering:{exercise.Rating}");
                exerciseNumber++;
            }

            var exerciseList = result.Select(mr => mr.Move).ToList();
            return exerciseList;
        }
	}
}

