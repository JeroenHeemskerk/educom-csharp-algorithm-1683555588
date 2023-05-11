using System;
using MySql.Data.MySqlClient;

namespace BornToMove
{
	public class kiezen
	{
        private MySqlConnection connection;

        public kiezen(MySqlConnection connection)
        {
            this.connection = connection;
        }

        public List<string> kiesActiviteit(MySqlConnection connection)
		{
            List<string> exerciseNames = new List<string>();
            Console.WriteLine("Hier is een lijst van beschikbare oefeningen: ");
            MySqlCommand exerciseList = new MySqlCommand("SELECT id, name, sweatRate FROM move", connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = exerciseList.ExecuteReader();
                int exerciseNumber = 1;

                while (reader.Read())
                {
                    string exerciseName = reader.GetString(1);
                    string exerciseIntensity = reader.GetString(2);
                    Console.WriteLine($"{exerciseNumber}. {exerciseName}. Intensiteit: {exerciseIntensity}");
                    exerciseNames.Add(exerciseName);
                    exerciseNumber++;
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
            return exerciseNames;
        }
	}
}

