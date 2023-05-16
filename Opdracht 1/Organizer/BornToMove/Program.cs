
using System;
using System.Security.Cryptography;
using BornToMove.DAL;


namespace BornToMove
{
    public class Program
    {
        public static void Main()
        {
             


            Console.WriteLine("Tijd om te bewegen!");
            string answer;
            Console.WriteLine("Wil je een bewegingssuggestie of zelf een oefening kiezen? (suggestie/kiezen/nee)");
            do
            {
                answer = Console.ReadLine().Trim().ToLower();
                if (answer == "suggestie")
                {
                    suggestie suggestieInstance = new suggestie();
                    Move move = suggestieInstance.suggestieMove();
                    feedback feedback = new feedback(move);
                }
                else if (answer == "kiezen")
                {
                    chooseExercise chooseExerciseInstance = new chooseExercise();
                    Move move = chooseExerciseInstance.chooseExerciseMove();
                    feedback feedback = new feedback(move);
                }
                else if (answer != "nee" && answer != "no")
                {
                    Console.WriteLine("Sorry, dat antwoord begrijp ik niet. Antwoord a.u.b. met suggestie, kiezen, of nee.");
                }
                else if (answer == "nee" || answer == "no")
                {
                    Console.WriteLine("Oke, tot de volgende keer en niet vergeten te bewegen!");
                }
            } while (answer != "nee" && answer != "no" && answer != "suggestie" && answer != "kiezen");
        }
    }
}