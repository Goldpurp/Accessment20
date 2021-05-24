using System;

namespace number1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("input first number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} / {1} = {2}", number1, number2, number1 / number2);
        }
    }
}
