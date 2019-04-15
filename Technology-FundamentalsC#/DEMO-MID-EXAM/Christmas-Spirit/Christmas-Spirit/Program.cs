using System;

namespace Christmas_Spirit
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int totalSpirit = 0;
            int budget = 0;

            for (int i = 1; i <= days; i++)
            {
                if (i%10==0&&i==days)
                {
                    totalSpirit -= 30;
                    
                }
                if (i % 11 == 0)
                {
                    quantity += 2;
                }
                if (i % 10 == 0)
                {
                    totalSpirit -= 20;
                    budget += 5 + 3 + 15;
                   
                }
                if (i % 3 == 0)
                {
                    budget += quantity * 5 + quantity * 3;
                    totalSpirit += 13;
                }
                 if (i % 5 == 0)
                {
                    budget += quantity * 15;
                    totalSpirit += 17;
                    if (i % 3 == 0)
                    {

                        totalSpirit += 30;
                    }

                }
                 if (i % 2 == 0)
                {
                    budget += quantity * 2;
                    totalSpirit += 5;
                }
            }
            Console.WriteLine($"Total cost: {budget}");
            Console.WriteLine($"Total spirit: {totalSpirit}");
        }
    }
}
