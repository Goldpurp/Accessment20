using System;

namespace number12
{
    class Program
    {
        static void Main(string[] args)
        { 
            int[] number1 = {4,2,6,2,4};
            int[] number2 = {5,2,5,7,1};

            int[] mult = new int[number1.Length];

            for( int i = 0; i < number1.Length; i++)
            {
                mult[i] = number1[i] * number2[i];

                Console.WriteLine(mult[i]);
            }  
        }
    }
}
