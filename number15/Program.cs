using System;

namespace number15
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c;

            a = 15;
            b = 25;
            c = 30;

            if( a > b && a > c)
            {
                Console.WriteLine($"A is the biggest integer");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine($"A is the biggest integer");
            }else
            {
                Console.WriteLine($"C is the biggest integer");
            }

            if (a < b && a < c)
            {
                Console.WriteLine($"A is the lowest integer");
            }
            else if (b < a && b < c)
            {
                Console.WriteLine($"A is the lowest integer");
            }
            else
            {
                Console.WriteLine($"C is the lowest integer");
            }

        }
    }
}
