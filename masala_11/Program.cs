using System;

namespace MyApplication
{
    class Programm
    {
        static bool TryCalculateAverage(int first, int second, int third, out int average)
        {
            if(first <= 100 && second <= 100 && third <= 100)
            {
                    average = (first + second + third)/3;
                    return true;
            }
            else
            {
                average = 0;
                return false;
            }
        }
        static void Main()
        {
            int first = 80, second = 101, third = 90;
            int average;
            bool result = TryCalculateAverage(first, second, third, out average);

            Console.WriteLine($"Muvaffaqiyatli: {result}");
            Console.WriteLine($"O'rtacha: {average}");
        }
    }
}