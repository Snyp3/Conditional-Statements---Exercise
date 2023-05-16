using System;

namespace P04.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double travel = double.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());   
            int dolls = int.Parse(Console.ReadLine());  
            int bears = int.Parse(Console.ReadLine());  
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
            
            int numberToys = puzzle + dolls + bears + minions + trucks; // брой играчки за поръчката
            double prizeToys = puzzle * 2.60 + dolls * 3 + bears * 4.10 + minions * 8.20 + trucks * 2; // за по лесно надолу отколкото 1во да пресметнем поотделно цената на вс и да ги повтаряме 1 по 1
            // double prizeToys = puzzle *2.60
            //                      +dolls *3
            //                      +bears * 4.10           и така става за по ясно и четливо
            //                      +minions * 8.20
            //                      +trucks * 2;
            if (numberToys >= 50)
            {
                prizeToys -= prizeToys * 0.25; // 25% отстъпка при +50 не ни трябва елсе
            }
            prizeToys -= prizeToys * 0.10;//10% наем от спечелените пари
            if (prizeToys >= travel)
            {
                Console.WriteLine($"Yes! {Math.Abs(prizeToys - travel):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {Math.Abs(prizeToys - travel):f2} lv needed.");
            }
                    

        }
    }
}
