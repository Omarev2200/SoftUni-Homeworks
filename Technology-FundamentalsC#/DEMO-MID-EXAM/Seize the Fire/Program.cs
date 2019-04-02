using System;
using System.Collections.Generic;
using System.Linq;

namespace Seize_the_Fire
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fireCells = Console.ReadLine()
                .Split('#')
                .ToList();
            int water = int.Parse(Console.ReadLine());

            int totalFire = 0;
            double effort = 0;
            Console.WriteLine("Cells:");
            for (int i = 0; i < fireCells.Count; i++)
            {

                string[] command = fireCells[i].Split(" = ").ToArray();
                string tupeFire = command[0];
                int range = int.Parse(command[1]);

                if (tupeFire == "High" && range >= 81 && range <= 125 && water >= 81 && range <= water)
                {
                    water -= range;
                    effort += range * 0.25;
                    totalFire += range;
                    Console.WriteLine($" - {range}");
                }
                if (tupeFire == "Medium" && range >= 51 && range <= 80 && water >= 51&&range<=water )
                {
                    water -= range;
                    effort += range * 0.25;
                    totalFire += range;
                    Console.WriteLine($" - {range}");
                }
                if (tupeFire == "Low" && range >= 1 && range <= 50 && water >= 1 && range <= water)
                {
                    water -= range;
                    effort += range * 0.25;
                    totalFire += range;
                    Console.WriteLine($" - {range}");
                }

            }
            Console.WriteLine($"Effort: {effort:f2}");
            Console.WriteLine($"Total Fire: {totalFire}");
        }
    }
}
