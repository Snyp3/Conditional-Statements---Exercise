using System;

namespace P08.LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int episodeTime = int.Parse(Console.ReadLine());
            int breakTime = int.Parse(Console.ReadLine());

            double timeForEpisode = (double)breakTime * 5 / 8;

            double difference = Math.Abs(timeForEpisode - episodeTime);

            if (timeForEpisode > episodeTime)
            {
                Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(difference)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(difference)} more minutes.");
            }
        }
    }
}
