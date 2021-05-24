using System;

namespace number11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("input second number: ");
            int b = int.Parse(Console.ReadLine());

            int sum = a + b;

            if(a == b)
            {
                Console.WriteLine(sum);
            }
        }
    }
}
