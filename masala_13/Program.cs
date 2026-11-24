using System;
using System.Security.Cryptography;

namespace MyApplication
{
    class Programm
    {
        static void ShowStudent(string name)
        {
            System.Console.WriteLine($"Talaba: {name}.");
        }
        static void ShowStudent(string name, int age, int ball)
        {
            if(age > 0 && age < 120 && ball > 0 && ball < 100)
            {
                System.Console.WriteLine((ball >= 60)?$"Talaba: {name}; Yosh: {age}; Baho: {ball}; Natija: O'tdi": $"Talaba: {name}; Yosh: {age}; Baho: {ball}; Natija: Mashq qilish kerak");
            }
            else
            {
                System.Console.WriteLine("Talaba ma'lumoti noto'g'ri.");
            }
        }
        static void Main()
        {
            ShowStudent("Ali");
            ShowStudent("Sara", 18, 60);
            ShowStudent("Bek", 16, 59);
            ShowStudent("Lola", 130, 80);
            ShowStudent("Olim", 15, 101);
        }
    }
}