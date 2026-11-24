using System;
using System.IO.Pipelines;

namespace MyApplication
{
    class Programm
    {
        static int GetTicketPrice(int age, bool isWeekend)
        {
            int cost = 0;
            if(age <= -1 || age > 120){ return -1; }
            else if(age < 7) return 0;  

            if(isWeekend) cost = 15000;
            else cost = 10000;
            
            if(age > 60) cost -= (cost / 100)*20; 
           
            return cost;

            }
        static void Main()
        {
            int age = 6;
            bool isWeekend = true;
            int price = GetTicketPrice(age, isWeekend);
            if (price == -1)
            {
                System.Console.WriteLine("Yosh noto'g'ri");
            }
            else if(price == 0)
            {
                    System.Console.WriteLine("Bepul");
            }
            else
            {
                System.Console.WriteLine(price);
            }
        }
    }
}