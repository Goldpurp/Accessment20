using System;

namespace number2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb1, numb2, temp;

            Console.Write("input first number: ");
            numb1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("input first number: ");
            numb2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" before swaping numb1 = {0} and numb2 = {1}", numb1, numb2);

            temp = numb1;

            numb1 = numb2;

            numb2 = temp;

            Console.WriteLine(" after swaping numb1 = {0} and numb2 = {1}", numb1, numb2);
        }
    }
}
