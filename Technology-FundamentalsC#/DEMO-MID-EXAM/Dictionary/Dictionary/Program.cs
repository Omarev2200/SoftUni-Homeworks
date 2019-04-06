using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, List<string>>();
           
            string[] pairsOfWordsAndDescriptions = Console.ReadLine().Split(" | ").ToArray();

            string command = string.Empty;

            for (int i = 0; i < pairsOfWordsAndDescriptions.Length; i++)
            {
                string[] wordDefinition = pairsOfWordsAndDescriptions[i].Split(": ");
                string word = wordDefinition[0];
                string definition = wordDefinition[1];
                if (!dictionary.ContainsKey(word))
                {
                    dictionary[word] = new List<string>();
                }
                dictionary[word].Add(definition);
            }
            while ((command = Console.ReadLine()) != "End")
            {
                if (command == "List")
                {
                    foreach (var kvp in dictionary.OrderBy(x=>x.Key))
                    {
                        Console.Write(kvp.Key+" ");
                    }
                    
                    break;
                }
                string[] word = command.Split(" | ");

                for (int i = 0; i < word.Length; i++)
                {
                    if (dictionary.ContainsKey(word[i]))
                    {
                        Console.WriteLine(word[i]);
                        foreach (var definition in dictionary[word[i]].OrderByDescending(x=>x.Length))
                        {
                            Console.WriteLine($" -{definition}");
                        }
                    }
                }
            }
        }
    }
}
