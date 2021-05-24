using System;

namespace number13
{
    class Program
    {
        static void Main(string[] args)
        {
            string val1 = "Teneficial";

            string val2 = "Talented";

            string val3 = "Congratulations";

            int v1 = val1.Length;

            int v2 = val2.Length;

            int v3 = val3.Length;

            Console.WriteLine($"{v1}, {v2}, {v3}");

            if (v1 > v2 && v1 > v3)
            {
                Console.WriteLine($"v1 is the longest with {v1} characters");

            }else if (v2 > v1 && v2 > v3)
            {
                Console.WriteLine($"v2 is the longest with {v2} characters");

            }else if (v3 > v1 && v3 > v2)
            {
                Console.WriteLine($"v3 is the longest with {v3} characters");
            }else
            {
                Console.WriteLine($"multiple stings are equal");
            }

            




        }
    }
}
