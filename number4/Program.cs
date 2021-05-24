using System;

namespace number4
{
    class Program
    {
        static void Main(string[] args)
        {

            Multiply(10, 20);

            
            // Console.Write("input first number: ");
            // int numb1 = Convert.ToInt32(Console.ReadLine());

            // Console.Write("input first number: ");
            // int numb2 = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("{0} + {1} = {2}", numb1, numb2, numb1 + numb2);

            // Console.WriteLine("{0} - {1} = {2}", numb1, numb2, numb1 - numb2);

            // Console.WriteLine("{0} * {1} = {2}", numb1, numb2, numb1 * numb2);

            // Console.WriteLine("{0} / {1} = {2}", numb1, numb2, numb1 / numb2);

        }
        static void Addition(int numb1, int numb2)
        {
            Console.WriteLine("{0} + {1} = {2}", numb1, numb2, numb1 + numb2);
        }
        static void Subtraction(int numb1, int numb2)
        {
            Console.WriteLine("{0} - {1} = {2}", numb1, numb2, numb1 - numb2);
        }
        static void Multiply(int numb1, int numb2)
        {
            Console.WriteLine("{0} * {1} = {2}", numb1, numb2, numb1 * numb2);
        }
        static void Division(int numb1, int numb2)
        {
            Console.WriteLine("{0} / {1} = {2}", numb1, numb2, numb1 / numb2);
        }
    }
}
