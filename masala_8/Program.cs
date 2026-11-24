using System;

namespace MyApplication
{
    class Programm
    {
        static void AddBonus(ref int score, int bonus)
        {
            if(score >= 0 && score <= 100)
            {
                score += bonus;
                if(score > 100) score = 100;
            }
        }
        static void Main()
        {
            int score = 105; 
            int bonus = 5; 
            Console.Write($"Oldingi: {score};");
            AddBonus(ref score, bonus);
            Console.WriteLine($" Keyingi: {score}");

        }
    }
}