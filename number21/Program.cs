using System;

namespace number21
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 9, 4, 3, 2, 5, 7 };

            Array.Sort(numbers);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
