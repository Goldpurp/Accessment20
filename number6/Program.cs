using System;

namespace number6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input Number: ");
            int multiply = Convert.ToInt32(Console.ReadLine());
            
            for(int i = 1; i <= 12; i++)
            {
                int result = multiply * i;
                Console.WriteLine(result);
            }
        }
    }
}
