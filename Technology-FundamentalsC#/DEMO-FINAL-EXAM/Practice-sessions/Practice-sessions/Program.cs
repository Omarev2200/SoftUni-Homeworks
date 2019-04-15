using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice_sessions
{
    class Program
    {
        static void Main(string[] args)
        {
            var roadRacer = new Dictionary<string, List<string>>();

            string commands = string.Empty;
            while ((commands=Console.ReadLine())!="END")
            {
                string[] command = commands.Split("->");
                
                if (command[0]== "Add")
                {
                    string road = command[1];
                    string racer = command[2];
                    if (!roadRacer.ContainsKey(road))
                    {
                        roadRacer[road] = new List<string>();
                    }
                    roadRacer[road].Add(racer);
                }
                if (command[0]== "Move")
                {
                    string currentRoad = command[1];
                    string racer = command[2];
                    string nextRoad = command[3];
                    if (roadRacer[currentRoad].Contains(racer))
                    {
                        roadRacer[currentRoad].Remove(racer);
                        roadRacer[nextRoad].Add(racer);
                    }
                }
                if (command[0]== "Close")
                {
                    string road = command[1];
                    if (roadRacer.ContainsKey(road))
                    {
                        roadRacer.Remove(road);
                    }
                }
            }
            Console.WriteLine("Practice sessions:");
            foreach (var kvp in roadRacer.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
            {
                Console.WriteLine(kvp.Key);
                
                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"++{item}");
                }
            }
        }
    }
}
