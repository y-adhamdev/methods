using System;

namespace MyApplication
{
    class Programm
    {
        static void GetNumberStats(int first, int second, int third, out int min, out int middle, out int max)
        {

            max = first;
            if(max < second) max = second;
            if(max < third) max = third;

            min = first;
            if(min > second)min = second;
            if(min > third)min = third;

            middle = (first + second + third) - (max + min);

        }
        static void Main()
        {
           int first = 0, second = 5, third = 10;
           int min, max, middle;

        GetNumberStats(first, second, third, out min, out middle, out max);
        Console.WriteLine($"Eng kichik: {min}; O'rtadagi: {middle}; Eng katta: {max}");
        }
    }
}