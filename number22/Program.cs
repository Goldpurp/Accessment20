using System;

namespace number22
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.Write("input number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            

            foreach(int number in numbers)
            {
                 if (number == input)
                 {
                Console.WriteLine("Array contains the input");
                 }
            }

            

        }
    }
}
