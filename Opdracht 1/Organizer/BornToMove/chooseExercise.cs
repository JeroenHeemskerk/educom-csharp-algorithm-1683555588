using System;
using System.Reflection.PortableExecutable;
using BornToMove.Business;
using BornToMove.DAL;

namespace BornToMove
{
	public class chooseExercise
	{
        public chooseExercise()
        {
            bool validExercise = false;
            do
            {
                var context = new MoveContext();
                var buMove = new BuMove(context);
                kiezen kiezen = new kiezen();
                List<Move> MovesList = kiezen.kiesActiviteit();
                Console.WriteLine("Kies een oefening uit de lijst door het nummer in te voeren of typ 0 om een oefening toe te voegen:");
                string chosenExercise = Console.ReadLine().Trim();
                if (chosenExercise == "0")
                {
                    enterMove enterMove = new enterMove();
                    chooseExercise exercise = new chooseExercise();
                }
                int intChosenExercise = int.Parse(chosenExercise);

                Console.WriteLine("De door jouw gekozen oefening is: {0}\n" +
                "Instructies: {1}.\n" +
                "Deze oefening heeft een intensiteitsniveau van: {2}",
               MovesList[intChosenExercise-1].Name, MovesList[intChosenExercise-1].Description, MovesList[intChosenExercise-1].SweatRate);
                validExercise = true;
     
            } while (!validExercise);
        }
    }
}

