
using System;
using System.Diagnostics;

namespace Organizer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hoeveel elementen moeten de lijsten bevatten?");
            int numElements = int.Parse(Console.ReadLine());

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            List<int> list = GetRandomList(numElements);
            stopwatch.Stop();
            Console.WriteLine("Elapsed time for get random list function: {0}", stopwatch.Elapsed);

            List<int> numbers = GetRandomList(numElements);
            var Shift = new ShiftHighestSort();
            stopwatch.Start();
            List<int> ShiftList = Shift.Sort(list);
            stopwatch.Stop();
            Console.WriteLine("Elapsed time for shift sorting function: {0}", stopwatch.Elapsed);

            TimeSpan first = stopwatch.Elapsed;
            CheckList(ShiftList);
            var RotateSort = new RotateSort();
            stopwatch.Start();
            RotateSort.Rotate(numbers, 0, numbers.Count-1);
            stopwatch.Stop();
            Console.WriteLine("Elapsed time for the partitioning sorting function: {0}", stopwatch.Elapsed);

            TimeSpan second = stopwatch.Elapsed;
            CheckList(numbers);
            double diff = (second.TotalMilliseconds / first.TotalMilliseconds) * 100;
            Console.WriteLine("The time difference between the functions is: {0}% (>100 " +
                "means the Shift method is faster)", diff);

            //numbers.ForEach(i => Console.Write("{0},\t", i));
            //Console.WriteLine();
            //ShiftList.ForEach(i => Console.Write("{0},\t", i));

        }

        public static List<int> GetRandomList(int numElements)
        {
            Random rnd = new Random();
            List<int> list = new List<int>();
            while (list.Count < numElements)
            {
                int randomNumber = rnd.Next(-99, 99);
                list.Add(randomNumber);
            }
            return list;
        }

        public static void CheckList(List <int> numbers)
        {
            bool isAscending = true;
            for (int i = 0;  i < numbers.Count-1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    isAscending = false; 
                    break;
                    throw new Exception("!!! List is not in the right order !!!");
                }
            }

            if (isAscending)
            {
                Console.WriteLine("The list is in Ascening order.");
            }
            else
            {
                Console.WriteLine("The list is not in ascending order.");
            }
        }
    }
}