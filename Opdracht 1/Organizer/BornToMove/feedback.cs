using System;
namespace BornToMove
{
	public class feedback
	{
		public feedback()
		{
			string answer;
			Console.WriteLine("Ben je klaar met de oefening? (ja/nee");
			do
			{
				answer = Console.ReadLine().Trim().ToLower();
				if (answer == "ja")
				{
                    Console.WriteLine("Great!");
                    string answerExercise, answerIntensity;
                    int ratingExercise, ratingIntensity;

                    do
                    {
                        Console.WriteLine("On a scale from 1-5, how was the exercise? (5 being amazing)");
                        answerExercise = Console.ReadLine().Trim().ToLower();

                    } while (!int.TryParse(answerExercise, out ratingExercise) || ratingExercise < 1 || ratingExercise > 5);

                    do
                    {
                        Console.WriteLine("On a scale from 1-5, how intense was the exercise?");
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

