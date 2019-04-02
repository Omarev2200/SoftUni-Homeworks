using System;

namespace TheHuntingGames
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int players = int.Parse(Console.ReadLine());
            decimal energyGroup = decimal.Parse(Console.ReadLine());
            decimal waterPerDayForOnePerson = decimal.Parse(Console.ReadLine());
            decimal foodPerDayForOnePerson = decimal.Parse(Console.ReadLine());

            decimal totalWater = days * players * waterPerDayForOnePerson;
            decimal totalFood = days * players * foodPerDayForOnePerson;

            for (int i = 1; i <= days; i++)
            {
                decimal energyLost = decimal.Parse(Console.ReadLine());
                energyGroup -= energyLost;
                if (energyGroup <= 0)
                {
                    Console.WriteLine($"You will run out of energy. You will be left with {totalFood:f2} food and {totalWater:f2} water.");
                    return;
                }
                if (i % 2 == 0)
                {

                    energyGroup += energyGroup * 0.05m;
                    totalWater -= totalWater * 0.30m;
                   
                }
                if (i % 3 == 0)
                {
                    energyGroup += energyGroup * 0.10m;
                    totalFood -= totalFood / players;
                }
            }

            Console.WriteLine($"You are ready for the quest. You will be left with - {energyGroup:f2} energy!");
        }
    }
}
