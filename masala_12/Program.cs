using System;

namespace MyApplication
{
    class Programm
    {
        static int GetPerimeter(int length)
        {
            if(length > 1 && length < 1000000)
            {
                return length * length;
            }
            else{
                return -1;
            }
        }
        static int GetPerimeter(int length1, int length2)
        {
            if(length1 > 1 && length1 < 1000000 && length2 >= 1 && length2 < 1000000)
            {
                return (length1 + length2)*2;
            }
            else{
                return -1;
            }
        }
        static int GetPerimeter(int length1, int length2, int length3 )
        {
            if(length1 > 1 && length1 < 1000000 && length2 >= 1 && length2 < 1000000 && length3 >= 1 && length3 < 100000)
            {
                return length1 + length2 + length3;
            }
            else
            {
                return -1;
            }
        }
        static void Main()
        {
            int length1 = 1, length2 = 2, length3 = 3;

            System.Console.WriteLine(GetPerimeter(length1, length2, length3));

        }
    }
}