using System;

namespace MyApplication
{
    class Programm
    {
        static int Add(int first, int second)
        {
            return first + second;
        }
        static void Main()
        {
            Console.Write("Butun son kiriting: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Butun son kiriting: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Natija: {num1} + {num2} =  {Add(num1, num2)}");
        }
    }
}