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
            List<Move> exerciseList = result.moves;
            List<double> averageRatings = result.averageRatings;
            Console.WriteLine($" average rating = {averageRatings[2]}");

            int exerciseNumber = 1;
            foreach (Move exercise in exerciseList)

            {
                Console.WriteLine($"{exerciseNumber}. {exercise.Name}, intensiteit: {exercise.SweatRate}, gemiddelde waardering:{averageRatings[exerciseNumber-1]}");
                exerciseNumber++;
            }
            return exerciseList;
        }
	}
}

