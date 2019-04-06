using System;
using System.Linq;

namespace LastStop
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersOfThePaintings = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string commands = string.Empty;
            foreach (var item in numbersOfThePaintings)
            {
                Console.WriteLine(item);
            }

            while ((commands=Console.ReadLine()) !="END")
            {
                string[] command = commands.Split().ToArray();
            }
        }
    }
}
