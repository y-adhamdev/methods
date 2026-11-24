using System;
using System.Runtime.CompilerServices;

namespace MyApplication
{
    class Programm
    {
        static void AnnounceTheResult(double result)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("===========================");
            Console.WriteLine($"Natija: {result:N2}");
            Console.WriteLine("===========================");
            Console.ResetColor();
        }
        static void GetCircleArea(double radius)
        {
            AnnounceTheResult(Math.PI * radius * radius);
        }
        static void GetCirclePerimeter(double radius)
        {
            AnnounceTheResult(2 * Math.PI * radius);            
        }
        static void GetRectangleArea(double width, double height)
        {
            AnnounceTheResult(width * height);
        }
        static void GetRectanglePerimeter(double width, double height)
        {
            AnnounceTheResult(2 * (width + height));
        }

        static void GetSquareArea(double side)
        {
           AnnounceTheResult(side * side);
        }
        static void GetSquarePerimeter(double side)
        {
            AnnounceTheResult(4 * side);
        }

        static string GetOrder()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("╔═══Tanlang══════════════╗");
            System.Console.WriteLine("1 - Yuza");
            System.Console.WriteLine("2 - Premetr");
            System.Console.WriteLine("0 - Orqaga");
             Console.WriteLine("╚════════════════════════╝");
            Console.Write("Tanlang: ");
            Console.ResetColor();
            string? choice = Console.ReadLine();

            return choice!;

        }

        static string GetMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("╔═══MENU═════════════════╗");
            Console.WriteLine(" 1 - Doira");
            Console.WriteLine(" 2 - To'g'ri to'rtburchak");
            Console.WriteLine(" 3 - Kvadrat");
            Console.WriteLine(" 0 - Chiqish");
            Console.WriteLine("╚════════════════════════╝");
            Console.Write("Tanlovingiz: ");
            Console.ResetColor();
            string? choice = Console.ReadLine();

            return choice!;
        }

        static void Main()
        {
            bool isDone = true;

            while (isDone)
            {
                string? choice = GetMenu();
                string choice2;

                switch (choice)
                {      
                    case "1": 
                        
                        choice2 = GetOrder();
                        if(choice2 != "0")
                        {
                            System.Console.Write("Doira radiusini kiriting: ");
                            double radius = Convert.ToDouble(Console.ReadLine());

                            if(choice2 == "1"){ GetCircleArea(radius);}
                            if(choice2 == "2"){ GetCirclePerimeter(radius);}
                        }
                        break;
                    
                    case "2":
                        choice2 = GetOrder();
                        if(choice2 != "0")
                        {
                            System.Console.Write("Bo'yini kiriting: ");
                            double height = Convert.ToDouble(Console.ReadLine());
                            System.Console.Write("Bo'yini kiriting: ");
                            double width = Convert.ToDouble(Console.ReadLine());

                            if(choice2 == "1"){ GetRectangleArea(width, height);}
                            if(choice2 == "2"){ GetRectanglePerimeter(width, height);}
                        }
                        break;

                    case "3":
                        choice2 = GetOrder();
                        if(choice2 != "0")
                        {
                            System.Console.Write("Tomonni kiriting: ");
                            double side = Convert.ToDouble(Console.ReadLine());
                            
                            if(choice2 == "1"){ GetSquareArea(side); }
                            if(choice2 == "2"){ GetSquarePerimeter(side); }
                        }
                        break;

                    case "0":
                            isDone = false;
                            break;
                        
                }
            }
        }
    }
}