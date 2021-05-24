using System;

namespace number14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Number: ");
            int number = int.Parse(Console.ReadLine());

            if(number % 3 == 0 && number % 7 != 0)
            {
                Console.WriteLine("It is a multiple of 3 but not a multiple of 7");

            }else if (number % 7 == 0 && number % 3 != 1)
            {
                Console.WriteLine("It is a multiple of 7 but not a multiple of 3");

            }else if (number % 3 != 0 && number % 7 != 0)
            {
                Console.WriteLine("It is neither a multiple of 3 nor 7");
            }else
            {
                Console.WriteLine("It is a multiple of both 3 and 7");
            }
            
        }
    }
}
