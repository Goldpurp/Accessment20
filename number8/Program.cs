using System;

namespace number8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input : ");
            int celsius = Convert.ToInt32(Console.ReadLine());

            double fahreheit = celsius * 1.8 + 32;

            double kelvin = celsius + 273.15;

            Console.WriteLine($"result for fahrenheit {fahreheit}");

            Console.WriteLine($"result for kelvin {kelvin}");
            
        }
    }
}
