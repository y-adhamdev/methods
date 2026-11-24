using System;

namespace MyApplication
{
    class Programm
    {
        static void ShowWelcome(string name)
        {
            System.Console.WriteLine($"Hello {name}!");
        }
        static void Main()
        {
            System.Console.Write("Ismingizni kiriting: ");
            string? userName = Console.ReadLine();
            ShowWelcome(userName!);
        }
    }
}