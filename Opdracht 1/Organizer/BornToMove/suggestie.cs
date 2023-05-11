using System;
using MySql.Data.MySqlClient;

namespace BornToMove
{
	public class suggestie
	{
		public suggestie(MySqlConnection connection)
		{
            MySqlCommand randomExercise = new MySqlCommand("SELECT name, description, sweatRate FROM move ORDER BY RAND() LIMIT 1", connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = randomExercise.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine("Je volgende oefening is: {0}\n" +
                        "Instructie: {1}.\n" +
                        "Deze oefening heeft een intensiteitsniveau van: {2}",
                        reader.GetString(0), reader.GetString(1), reader.GetString(2));
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
        }
	}
}

