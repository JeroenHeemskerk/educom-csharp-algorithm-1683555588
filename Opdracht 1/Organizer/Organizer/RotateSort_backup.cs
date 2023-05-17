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
        public void Rotate(List<int> numbers, int left, int right)
        {
            if (right - left < 1)
            {
                return;
            }
            int pivotIndex = Partitioning(numbers, left, right);

            Rotate(numbers, left, pivotIndex - 1);
            Rotate(numbers, pivotIndex + 1, right);
        }

        public int Partitioning(List<int> numbers, int left, int right)
        {
            int pivotIndex = new Random().Next(left, right+1);
            int pivot = numbers[pivotIndex];
            numbers[pivotIndex] = numbers[right];
            numbers[right] = pivot;

            int i = left;
            for (int j = left; j < right; j++)
            {
                if (numbers[j] <= pivot)
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                    i++;
                }
            }
            numbers[right] = numbers[i];
            numbers[i] = pivot;

            return i;
        }
    }



}

