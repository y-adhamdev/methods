using System;

namespace MyApplication
{
    class Programm
    {
        static string CreateOrderMessage(string product, int quantity)
        {
            return $"Buyurtma: {quantity} {product} ";
        }
        
        static void Main()
        {
            System.Console.WriteLine(CreateOrderMessage("Kitob", 2));
        }
    }
}