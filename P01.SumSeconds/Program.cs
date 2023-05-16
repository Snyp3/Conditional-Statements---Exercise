using System;

namespace P01.SumSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
               // Трима спортни състезатели финишират за някакъв брой секунди(между 1 и 50). Да се напише програма, която чете времената на състезателите в секунди,
               // въведени от потребителя и пресмята сумарното им време във формат "минути:секунди".Секундите да се изведат с водеща нула(2  "02", 7  "07", 35  "35"). 
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int totalTime = first + second + third; // секунди
            int min = totalTime / 60;
            int sec = totalTime % 60;
            if (sec<10)
            {
                Console.WriteLine($"{min}:0{sec}");
            }
            else
            {
                Console.WriteLine($"{min}:{sec}");
            }
        }
    }
}
