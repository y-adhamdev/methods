using System;

namespace MyApplication
{
    class Programm
    {
        static bool TrySellItems(ref int stock, int quantity)
        {
            if(stock >= 0 && quantity >= 0 && stock >= quantity)
            {
                stock -= quantity;
                return true;

            }else return false;
        }
        static void Main()
        {
            int stock = 5; 
            int quantity = -1;
            bool isDone = TrySellItems(ref stock, quantity);

            Console.WriteLine($"Muvaffaqiyat: {isDone}");
            System.Console.WriteLine($"Ombordagilar soni: {stock}");

        }
    }
}