using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Activation_Keys
{
    class Program
    {


        public static object StrigBild { get; private set; }

        static void Main(string[] args)
        {
            string[] keysOfTheGames = Console.ReadLine().Split("&", StringSplitOptions.RemoveEmptyEntries).ToArray();

            string gameCode = string.Empty;

            var sb = new List<string>();

            for (int i = 0; i < keysOfTheGames.Length; i++)
            {
                int lent = keysOfTheGames[i].Length;
                string code = keysOfTheGames[i];

                if (lent == 25)
                {
                    for (int j = 0; j < code.Length; j++)
                    {
                        char symbol = code[j];
                        if (char.IsDigit(symbol))
                        {
                            int digit = 9 - int.Parse(symbol.ToString());
                            gameCode = gameCode + digit;
                        }
                        else
                        {
                            if (char.IsLetter(symbol))
                            {
                                gameCode = gameCode + symbol;
                            }
                        }
                        if (j == 4 || j == 9 || j == 14 || j == 19)
                        {
                            gameCode = gameCode + '-';
                        }
                    }
                    sb.Add(gameCode.ToUpper());

                }
                if (lent == 16)
                {
                    for (int j = 0; j < code.Length; j++)
                    {
                        char symbol = code[j];
                        if (char.IsDigit(symbol))
                        {
                            int digit = 9 - int.Parse(symbol.ToString());
                            gameCode = gameCode + digit;
                        }
                        else
                        {
                            if (char.IsLetter(symbol))
                            {
                                gameCode = gameCode + symbol;
                            }

                        }
                        if (j == 3 || j == 7 || j == 11)
                        {
                            gameCode = gameCode + '-';

                        }
                    }
                    sb.Add(gameCode.ToUpper());
                }

                gameCode = string.Empty;
            }
            Console.WriteLine(string.Join(", ", sb));
        }
    }
}
