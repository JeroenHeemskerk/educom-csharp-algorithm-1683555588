using System;
using System.Reflection.PortableExecutable;
using MySql.Data.MySqlClient;

namespace BornToMove
{
	public class chooseExercise
	{
        public chooseExercise(MySqlConnection connection)
        {
            bool validExercise = false;
            do
            {
                List<string> exerciseNames = new List<string>();
                kiezen kiezen = new kiezen(connection);
                exerciseNames = kiezen.kiesActiviteit(connection);
                Console.WriteLine("Kies een oefening uit de lijst door het nummer in te voeren of typ 0 om een oefening toe te voegen:");
                string chosenExercise = Console.ReadLine().Trim();
                if (chosenExercise == "0")
                {
                    enterMove enterMove = new enterMove(connection);
                    chooseExercise exercise = new chooseExercise(connection);
                }

                int intChosenExercise = int.Parse(chosenExercise);
                string selector = (exerciseNames[intChosenExercise-1]);
                MySqlCommand chosenExerciseCommand = new MySqlCommand($"SELECT name, description, sweatRate FROM move WHERE name = '{selector}'", connection);

                try
                {
                        connection.Open();
                        MySqlDataReader reader = chosenExerciseCommand.ExecuteReader();
                
                    if (reader.HasRows)
                    {
                        reader.Read();
                        Console.WriteLine("De door jouw gekozen oefening is: {0}\n" +
                        "Instructies: {1}.\n" +
                        "Deze oefening heeft een intensiteitsniveau van: {2}",
                        reader.GetString(0), reader.GetString(1), reader.GetString(2));
                        validExercise = true;
                      
                    }
                    else
                    {
                        Console.WriteLine("Sorry, die oefening is niet beschikbaar. Kies a.u.b. een andere oefening.");

                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: {0}", ex.ToString());
                }
                finally
                {
                    connection.Close();
                }
            } while (!validExercise);
        }
    }
}

