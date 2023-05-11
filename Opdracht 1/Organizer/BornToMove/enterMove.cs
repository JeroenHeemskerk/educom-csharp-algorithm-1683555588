using System;
using MySql.Data.MySqlClient;

namespace BornToMove
{
	public class enterMove
	{
		public enterMove(MySqlConnection connection)
		{
			Console.WriteLine("Je hebt gekozen om een nieuwe oefening toe te voegen.");
            int count = 0;
            string name;
            do
            {
                Console.WriteLine("Wat is de naam van de oefening?");
                name = Console.ReadLine().Trim().ToLower();
                MySqlCommand checkName = new MySqlCommand("SELECT COUNT(*) FROM move WHERE name = @name", connection);
                checkName.Parameters.AddWithValue("@name", name);

                try
                {
                    connection.Open();
                    count = Convert.ToInt32(checkName.ExecuteScalar());

                    if (count > 0)
                    {
                        Console.WriteLine("Sorry, maar deze activiteit is al aanwezig.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error:{0}", ex.ToString());
                }
                finally
                {
                    connection.Close();
                }
            } while (count != 0);


            Console.WriteLine("Wat zijn de instructies?");
			string description = Console.ReadLine().Trim();
			Console.WriteLine("Van 1-5, hoe intens is deze oefening?");
			string sweatRate = Console.ReadLine().Trim();
            while (sweatRate != "1" && sweatRate != "2" && sweatRate != "3" && sweatRate != "4" && sweatRate != "5")
            {
                Console.WriteLine("Ongeldige invoer. Voer a.u.b. een getal tussen 1 en 5 in:");
                sweatRate = Console.ReadLine().Trim();
            }
            Console.WriteLine("Top! Ik zal de oefeningen toevoegen aan de lijst");

            MySqlCommand enterExercise = new MySqlCommand("INSERT INTO move " +
				"(name, description, sweatRate) " +
				"VALUES (@name, @description, @sweatRate)", connection);
            enterExercise.Parameters.AddWithValue("@name", name);
            enterExercise.Parameters.AddWithValue("@description", description);
            enterExercise.Parameters.AddWithValue("@sweatRate", sweatRate);
			try
			{
				connection.Open();
                enterExercise.ExecuteNonQuery();
            }
            catch (Exception ex)
			{
				Console.WriteLine("Error:{0}", ex.ToString());
			}
			finally
			{
				connection.Close();
			}
        }
    }
}

