
using System;
using System.Collections.Generic;
using System.Linq;

namespace Organizer
{
    public class RotateSort<T>
    {
        private IComparer<T> comparer;

        public void Sort(List<T> items, IComparer<T> comparer)
        {
            this.comparer = comparer;
            Rotate(items, 0, items.Count - 1);
        }

        private void Rotate(List<T> items, int left, int right)
        {
            Console.WriteLine(items);
            if (right - left < 1)
            {
                return;
            }
            int pivotIndex = Partitioning(items, left, right);

            Rotate(items, left, pivotIndex - 1);
            Rotate(items, pivotIndex + 1, right);
        }

        private int Partitioning(List<T> items, int left, int right)
        {
            int pivotIndex = new Random().Next(left, right + 1);
            T pivot = items[pivotIndex];
            items[pivotIndex] = items[right];
            items[right] = pivot;

            int i = left;
            for (int j = left; j < right; j++)
            {
                if (comparer.Compare(items[j], pivot) <= 0)
                {
                    T temp = items[i];
                    items[i] = items[j];
                    items[j] = temp;
                    i++;
                }
            }
            items[right] = items[i];
            items[i] = pivot;

            return i;
        }
    }
}
