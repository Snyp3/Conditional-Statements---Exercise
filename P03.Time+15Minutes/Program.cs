using System;

namespace P03.Time_15Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която чете час и минути от 24-часово денонощие, въведени от потребителя и изчислява колко ще е часът след 15 минути.
            //Резултатът да се отпечата във формат часове:минути. Часовете винаги са между 0 и 23, а минутите винаги са между 0 и 59.
            //Часовете се изписват с една или две цифри. Минутите се изписват винаги с по две цифри, с водеща нула, когато е необходимо. 
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes = minutes + hours * 60; // minutes += hours * 60
            minutes += 15;
            hours = minutes / 60;
            minutes = minutes % 60;
            if (hours == 24) //bool newDay = hours == 24;ako newDay e true връчща if ако е False  отива на else
            {
                Console.WriteLine($"0:{minutes:D2}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutes:D2}");
            }
        }
    }
}
