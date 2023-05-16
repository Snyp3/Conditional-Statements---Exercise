using System;

namespace P07.Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.	Бюджетът на Петър - реално число в интервала [0.0…100000.0]
            double budget = double.Parse(Console.ReadLine());
            // 2.	Броят видеокарти - цяло число в интервала [0…100]
            int vCards = int.Parse(Console.ReadLine());
            // 3.	Броят процесори - цяло число в интервала [0…100]
            int proces = int.Parse(Console.ReadLine());
            // 4.   Броят рам памет -цяло число в интервала[0…100]
            int ram = int.Parse(Console.ReadLine());

            // видео карта цена 250лв.
            double vCardsPrise = vCards * 250;
            // процесор 35% от видеокартата
            double procesPrise = vCardsPrise * 0.35;
            // рам 10% от видеокартата
            double ramPrise = vCardsPrise * 0.10;
            double totalPrise = ram * ramPrise +  proces * procesPrise + vCardsPrise;
            // ако видео картите > процесори 15% отстъпка от крайната цена
            if (vCards>proces)
            {
                totalPrise -= totalPrise * 0.15;
            }
            // •	Ако бюджета е достатъчен:
            // "You have {остатъчен бюджет} leva left!"
            if (budget >= totalPrise)
            {
                Console.WriteLine($"You have {Math.Abs(budget - totalPrise):f2} leva left!");// Резултатът да се форматира до втория знак след десетичната запетая.
            }
            // •	Ако сумата надхвърля бюджета:
            // "Not enough money! You need {нужна сума} leva more!"
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(budget-totalPrise):f2} leva more!");
            }
            
            
            
        }
    }
}
