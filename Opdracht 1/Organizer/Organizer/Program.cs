
namespace Organizer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = GetRandomList();
            var Shift = new ShiftHighestSort();
            List<int> ShiftList = Shift.Sort(list);
            CheckList(ShiftList);

            var RotateSort = new RotateSort();
            List<int> Rotatelist = RotateSort.Rotate(list);
            ShiftList.ForEach(i => Console.Write("{0},\t", i));
            Rotatelist.ForEach(i => Console.Write("{0},\t", i));

        }

        public static List<int> GetRandomList()
        {
            Random rnd = new Random();
            List<int> list = new List<int>();
            while (list.Count < 10)
            {
                int randomNumber = rnd.Next(-99, 99);
                list.Add(randomNumber);
                Console.WriteLine(randomNumber);
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