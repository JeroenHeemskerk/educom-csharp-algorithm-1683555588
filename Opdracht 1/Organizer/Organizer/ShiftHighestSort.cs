using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Organizer
{
    public class ShiftHighestSort
    {
   

        public List<int> Sort(List <int> numbers)
        {
            List<int> result = SortFunction(numbers);
            return result;
        }


        private List<int> SortFunction(List<int> numbers)
        {
            for (int x = 0; x < numbers.Count; x++)
            {
                for (int i = 0; i < numbers.Count - x-1; i++)
                {

                    if (numbers[i] > numbers[i + 1])
                    {
                        int first = numbers[i];
                        int second = numbers[i + 1];
                        numbers[i] = second;
                        numbers[i + 1] = first;
                    }
                    /*numbers.ForEach(i => Console.Write("{0}\t", i));*/
                }
            }
            return numbers;
        }

    }

  

}


