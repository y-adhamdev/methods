using System;

namespace MyApplication
{
    class Programm
    {
        static bool TryDvide(int number, int divisor, out int quotient, out int remainder)
        {
            if(divisor == 0)
            { 
                quotient = 0;
                remainder = 0;
                return false;
            }
            quotient = number / divisor;
            remainder = number % divisor;
            return true;
        }
        static void Main()
        {
            int number = 8, divisor = 0;
            int quotient, remainder;
            bool result = TryDvide(number, divisor, out quotient, out remainder);
            if (result)
            {
                System.Console.WriteLine($"Bo'linma: {quotient}\nQoldiq: {remainder}");
            }
            else
            {
                System.Console.WriteLine("Nolga bo'lish mumkin emas");
            }
        }
    }
}