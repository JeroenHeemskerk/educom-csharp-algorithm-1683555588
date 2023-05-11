using System;
using MySql.Data.MySqlClient;
using System.Collections.Specialized;

namespace BornToMove
{
	public class dictionary
	{

        public OrderedDictionary NameDictionary(MySqlConnection connection)
        {
            OrderedDictionary nameDict = new OrderedDictionary();

            MySqlCommand command = new MySqlCommand("SELECT name FROM move ORDER BY id", connection);

            try
            {
                connection.Open();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    int i = 1;
                    while (reader.Read())
                    {
                        string name = reader.GetString(0);
                        nameDict.Add(i, name);
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            return nameDict;
        }

    }
}

