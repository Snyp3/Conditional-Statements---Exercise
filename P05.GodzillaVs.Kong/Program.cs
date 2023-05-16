using System;
using System.Transactions;

namespace P05.GodzillaVs.Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ред 1.Бюджет за филма – реално число в интервала[1.00 … 1000000.00]
            double budget = double.Parse(Console.ReadLine());
            //Ред 2.Брой на статистите – цяло число в интервала[1 … 500]
            int statist = int.Parse(Console.ReadLine());
            //Ред 3.Цена за облекло на един статист – реално число в интервала[1.00 … 1000.00]
            double statistDressPrise = double.Parse(Console.ReadLine());
            // сума на декора 10% от budget
            double dekor = budget * 0.1;
            if (statist > 150)
            {
                statistDressPrise -= statistDressPrise * 0.1; // 10% отстъпка на облеклото ако има пожече от 150 статисти
            }
            // сума за облекло
            double totalDressPrise = statist * statistDressPrise;
            double totalPrise = dekor + totalDressPrise;

            // На конзолата трябва да се отпечатат два реда:
            // •	Ако парите за декора и дрехите са повече от бюджета:
            // o   "Not enough money!"
            // o   "Wingard needs {парите недостигащи за филма} leva more."
            // •	Ако парите за декора и дрехите са по малко или равни на бюджета:
            //             o   "Action!"
            // o   "Wingard starts filming with {останалите пари} leva left."
            // Резултатът трябва да е форматиран до втория знак след десетичната запетая.
            // 
            if (totalPrise > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(budget - totalPrise):f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {Math.Abs(totalPrise - budget):f2} leva left.");
            }
        }
    }
}

