using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Song_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string paterrn = @"^(?<artist>[A-Z][a-z\' ]+):(?<song>[A-Z\' ]+)$";
            string enkrypt = string.Empty;
            string command = string.Empty;
            int count = 0;
            int symbol = 0;
            while ((command=Console.ReadLine())!="end")
            {
                
                Regex order = new Regex(paterrn);
                if (order.IsMatch(command))
                {
                    string artistName = order.Match(command).Groups["artist"].Value;
                    string songName = order.Match(command).Groups["song"].Value;
                    int key = artistName.Length;

                    for (int i = 0; i < artistName.Length; i++)
                    {

                        if (artistName[i] >= 65 && artistName[i] <= 90)
                        {
                            symbol = artistName[i] + key;
                            if (symbol > 90)
                            {
                                count = symbol - 90;
                                symbol = count + 65;
                                enkrypt = enkrypt + (char)symbol;
                            }
                            else
                            {
                                enkrypt = enkrypt + (char)symbol;
                            }

                            continue;
                        }

                        if (artistName[i] == 39 || artistName[i] == 32)
                        {
                            enkrypt = enkrypt + artistName[i];
                            continue;
                        }

                        symbol = artistName[i] + key;
                        if (symbol > 122)
                        {
                            count = symbol - 122;
                            symbol = count + 96;
                            enkrypt = enkrypt + (char)symbol;
                        }
                        else
                        {
                            enkrypt = enkrypt + (char)symbol;
                        }

                    }
                    enkrypt += '@';
                    for (int j = 0; j < songName.Length; j++)
                    {

                        if (songName[j] == 39 || songName[j] == 32)
                        {
                            enkrypt = enkrypt + songName[j];
                            continue;
                        }

                        symbol = songName[j] + key;
                        if (symbol > 90)
                        {
                            count = symbol - 90;
                            symbol = count + 64;
                            enkrypt = enkrypt + (char)symbol;
                        }
                        else
                        {
                            enkrypt = enkrypt + (char)symbol;
                        }

                    }
                    Console.WriteLine($"Successful encryption: {enkrypt}");
                    enkrypt = string.Empty;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
