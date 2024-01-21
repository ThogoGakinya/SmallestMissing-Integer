using System.ComponentModel.Design;

namespace SmallestMissing_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] MyArray = {1,2,3,34,67,89};
            solution(MyArray);
            
        }

        public static int solution(int[] A)
        {
            List<int> positiveIntegers = new List<int>();

            // Add positive integers to the set
            foreach (int num in A)
            {
                if (num > 0)
                {
                    positiveIntegers.Add(num);
                }
            }

            // Find the smallest missing positive integer
            int smallestMissing = 1;
            while (positiveIntegers.Contains(smallestMissing))
            {
                smallestMissing++;
            }
            Console.WriteLine("The number is {0}", smallestMissing);
            return smallestMissing;
            

        }
    }
}
