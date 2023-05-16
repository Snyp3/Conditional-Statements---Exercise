using System;
using System.Transactions;

namespace P06.WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Рекордът в секунди – реално число в интервала[0.00 … 100000.00]
            double sec = double.Parse(Console.ReadLine());
            //2.Разстоянието в метри – реално число в интервала[0.00 … 100000.00]
            double meters = double.Parse(Console.ReadLine());
            //3.Времето в секунди, за което плува разстояние от 1 м. - реално число в интервала[0.00 … 1000.00]
            double secMeters = double.Parse(Console.ReadLine());
            double timeFinish = meters * secMeters;
            // Съпротивление на водата на всеки 15м - 12.5 секунди          
            double waterResistance = Math.Floor(meters / 15);
            double waterResistanceTime = waterResistance * 12.5;
            double totalTime = waterResistanceTime + timeFinish; //общо време
            // Math.Floor() след като се изчисли забавянето

            if (sec > totalTime)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {(totalTime):f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {(totalTime - sec):f2} seconds slower.");
            }
        }
    }
}