using System;
using BornToMove.Business;
using BornToMove.DAL;

namespace BornToMove
{
	public class feedback
	{
		public feedback(Move move)
		{
			string answer;
			Console.WriteLine("Ben je klaar met de oefening? (ja/nee)");
			do
			{
				answer = Console.ReadLine().Trim().ToLower();
				if (answer == "ja")
				{
                    Console.WriteLine("Top!");
                    string answerExercise, answerIntensity;
                    int ratingExercise, ratingIntensity;
                    var context = new MoveContext();
                    var buMoveRating = new BuMoveRating(context);

                    do
                    {
                        Console.WriteLine("Op een schaal van 1-5, hoe leuk vond je de oefening? (5 is geweldig)");
                        answerExercise = Console.ReadLine().Trim().ToLower();

                    } while (!int.TryParse(answerExercise, out ratingExercise) || ratingExercise < 1 || ratingExercise > 5);
                    double doubleAnswerExercise = Convert.ToDouble(answerExercise);
                    double vote = 1;
                    buMoveRating.CreateMoveRating(move, doubleAnswerExercise, vote);

                    do
                    {
                        Console.WriteLine("Op een schaal van 1-5, hoe intens was deze oefening?");
                        answerIntensity = Console.ReadLine().Trim().ToLower();

                    } while (!int.TryParse(answerIntensity, out ratingIntensity) || ratingIntensity < 1 || ratingIntensity > 5);

                }
                else if (answer =="nee")
                {
                    Console.WriteLine("Geen probleem.\n" +
                        "antwoord met ja wanneer je klaar bent.");
                }
                else if (answer != "nee" && answer != "ja")
                {
                    Console.WriteLine("Sorry, dat antwoord begrijp ik niet. Antwoord a.u.b. met ja of nee.");
                }

            } while (answer != "ja" && answer != "yes");

		}
	}
}

