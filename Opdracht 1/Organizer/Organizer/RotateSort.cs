using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Organizer
{
    internal class RotateSort
    {
        public List<int> Rotate(List<int> numbers) 
        
                var random = new Random();
                int rnd = random.Next(numbers.Count);
                int pivot = numbers[rnd];
                List<int> result = Partition(pivot, numbers);
            return result;
        }

        public List<int> Partition(int RandomElement, List <int> numbers)
        {
            List<int> Left = new List<int>();
            List<int> Right = new List<int>();
            Console.WriteLine("Random element:");
            Console.WriteLine(RandomElement);
            for (int i = 0; i < numbers.Count; i++){
                if (numbers[i] <= RandomElement)
                {
                    Left.Add(numbers[i]);
                } else
                {
                    Right.Add(numbers[i]);
                }
            }
            Console.WriteLine("Left");
            Left.ForEach(i => Console.Write("{0},\t", i));
            Console.WriteLine("right");
            Right.ForEach(i => Console.Write("{0},\t", i));
            Left.AddRange(Right);
            List<int> result = Left;
        return result;
        }
    }
}
