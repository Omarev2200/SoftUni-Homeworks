using System;
using System.Collections.Generic;
using System.Linq;

namespace Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeBand = new Dictionary<string, int>();
            var bandMebers = new Dictionary<string, List<string>>();

            string commands = string.Empty;
            int totalTime = 0;


            while ((commands = Console.ReadLine()) != "start of concert")
            {
                string[] command = commands.Split("; ").ToArray();

                if (command[0] == "Add")
                {
                    string band = command[1];
                    string[] memberName = command[2].Split(", ").ToArray();
                    if (!bandMebers.ContainsKey(band))
                    {
                        bandMebers[band] = new List<string>();
                    }
                    for (int i = 0; i < memberName.Length; i++)
                    {
                        if (!bandMebers[band].Contains(memberName[i]))
                        {
                            bandMebers[band].Add(memberName[i]);
                        }
                    }

                }
                else if (command[0] == "Play")
                {
                    string band = command[1];
                    int time = int.Parse(command[2]);

                    if (!timeBand.ContainsKey(band))
                    {
                        timeBand[band] = time;
                    }
                    else
                    {
                        timeBand[band] += time;
                    }

                    totalTime += time;

                }
            }
            string finalLine = Console.ReadLine();
            Console.WriteLine($"Total time: {totalTime}");
            foreach (var kvp in timeBand.OrderByDescending(x=>x.Value).ThenBy(y=>y.Key))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");

                if (true)
                {

                }
            }
            foreach (var kvp in bandMebers)
            {
                if (kvp.Key == finalLine)
                {


                    Console.WriteLine(kvp.Key);
                    foreach (var item in kvp.Value)
                    {
                        Console.WriteLine($"=> {item}");
                    }
                }
            }
        }
    }
}
