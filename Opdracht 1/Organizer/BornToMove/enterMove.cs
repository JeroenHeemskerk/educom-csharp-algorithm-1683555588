
using System;
using BornToMove.DAL;
using BornToMove.Business;

namespace BornToMove
{
	public class enterMove
	{
		public enterMove()
		{
            var context = new MoveContext();
            var buMove = new BuMove(context);
            
            Console.WriteLine("Je hebt gekozen om een nieuwe oefening toe te voegen.");
            Console.WriteLine("Wat is de naam van de oefening?");
            int test = 1;
            string name;
            do
            {
                name = Console.ReadLine().Trim().ToLower();
                Move checkName = buMove.GetMoveByName(name);
                if (checkName == null)
                {
                    test = 0;
                } else
                {
                    Console.WriteLine("Sorry, deze naam/oefening is al aanwezig. Kies a.u.b. een andere naam/oefening.");
                }
            } while (test != 0);

            Console.WriteLine("Wat zijn de instructies?");
			string description = Console.ReadLine().Trim();
			Console.WriteLine("Van 1-5, hoe intens is deze oefening?");
			string stringSweatRate = Console.ReadLine().Trim();
            int sweatRate = Int32.Parse(stringSweatRate);
            while (sweatRate != 1 && sweatRate != 2 && sweatRate != 3 && sweatRate != 4 && sweatRate != 5)
            {
                Console.WriteLine("Ongeldige invoer. Voer a.u.b. een getal tussen 1 en 5 in:");
                stringSweatRate = Console.ReadLine().Trim();
                sweatRate = Int32.Parse(stringSweatRate);
            }
            Console.WriteLine("Top! Ik zal de oefeningen toevoegen aan de lijst");

            buMove.CreateMove(name, description, sweatRate);

  
        }
    }
}



