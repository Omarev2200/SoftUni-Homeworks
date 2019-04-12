
using System;
using System.Collections.Generic;
using System.Linq;

namespace test1
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            var gamePrices = new Dictionary<string, double>();
            var gameDLC = new Dictionary<string, string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Contains('-'))
                {
                    string[] gamePrice = input[i].Split('-', StringSplitOptions.RemoveEmptyEntries);
                    string game = gamePrice[0];
                    double price = double.Parse(gamePrice[1]);
                    if (gamePrices.ContainsKey(game) == false)
                    {
                        gamePrices[game] = 0.00;

                    }
                    gamePrices[game] = price;
                }
                if (input[i].Contains(':'))
                {
                    string[] gameUp = input[i].Split(':', StringSplitOptions.RemoveEmptyEntries);
                    string games = gameUp[0];
                    string dlc = gameUp[1];
                    if (gamePrices.ContainsKey(games))
                    {
                        gameDLC[games] = dlc;
                        gamePrices[games] *= 1.20;

                    }
                }
            }
            Dictionary<string, double> gamesReducedPrise = new Dictionary<string, double>();
            foreach (var game in gamePrices)
            {
                if (gameDLC.ContainsKey(game.Key))
                {
                    gamesReducedPrise[game.Key] = game.Value * 0.5;
                }
                else
                {
                    gamesReducedPrise[game.Key] = game.Value * 0.8;
                }
            }

            foreach (var game in gamesReducedPrise.OrderBy(x => x.Value))
            {
                if (gameDLC.ContainsKey(game.Key))
                {
                    Console.WriteLine($"{game.Key} - {gameDLC[game.Key]} - {game.Value:F2}");
                }

            }

            foreach (var game in gamesReducedPrise.OrderByDescending(x => x.Value))
            {
                if (!gameDLC.ContainsKey(game.Key))
                {
                    Console.WriteLine($"{game.Key} - {game.Value:F2}");
                }
            }
        }
    }
}

}
    }
}
