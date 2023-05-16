using System;

namespace P08.LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.	Име на сериал – текст
            string name = Console.ReadLine();
            // 2.	Продължителност на епизод  – цяло число в диапазона [10… 90]
            int episodeTime = int.Parse(Console.ReadLine());
            // 3.Продължителност на почивката  – цяло число в диапазона[10… 120]
            int breakTime = int.Parse(Console.ReadLine());
            // Време за обяд 1/8 от почивката
            double lunchTime = (double)breakTime * 1 / 8;
            // Време за отдих 1/4 от почивката
            double relaxTime = (double)breakTime * 1 / 4;
            // Останалото време
            double timeLeft = breakTime - lunchTime - relaxTime;
            //Останалото време е по-голямо или равно на продължителността на епизода, следователно печатаме подходящия изход. 
            // •	Ако времето е достатъчно да изгледате епизода:
            if (timeLeft >= episodeTime)
            {
                Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(timeLeft - episodeTime)} minutes free time.");
            }
            // "You have enough time to watch {име на сериал} and left with {останало време} minutes free time."
            // •	Ако времето не Ви е достатъчно:
            else
            {
                Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(episodeTime - timeLeft)} more minutes.");

            }
            // Времето да се закръгли до най-близкото цяло число нагоре.
            // "You don't have enough time to watch {име на сериал}, you need {нужно време} more minutes."
        }
    }
}
