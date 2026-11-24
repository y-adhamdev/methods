using System;

namespace MyApplication
{
    class Programm
    {
        static int CalculateTotal(int cost, int quantity)
        {
            if(cost >= 1 && cost <= 1000000 && quantity >= 0 && quantity <= 1000)
            {
                return cost * quantity;
            }
            else
            {
                return -1;
            }
        }

        static int CalculateTotal(int cost, int quantity, int discount)
        {
            int TotalCost = CalculateTotal(cost, quantity);
            if(discount < TotalCost )
            {
                return TotalCost - discount;
            }
            else
            {
                return -1;
            }
            
        }
        static void Main()
        {
            System.Console.WriteLine(CalculateTotal(5000, 3));
            System.Console.WriteLine(CalculateTotal(5000, 3, 2000));
            System.Console.WriteLine(CalculateTotal(1200, 2, 400));
            System.Console.WriteLine(CalculateTotal(5000, 0));
            System.Console.WriteLine(CalculateTotal(5000, 2, 10000));
            System.Console.WriteLine(CalculateTotal(0, 3));
        }
    }
}