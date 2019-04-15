using System;
using System.Collections.Generic;

namespace InternationalSoftUniada
{
    class Program
    {
        static void Main(string[] args)
        {
            var countryNamePoints = new Dictionary<string, int>();
            var countryContestantName = new Dictionary<string, List<string>>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] countryContestantNamePoints = input.Split(" -> ");
                string country = countryContestantNamePoints[0];
                string contestantName = countryContestantNamePoints[1];
                int points = int.Parse(countryContestantNamePoints[2]);

                if (!countryContestantName.ContainsKey(country)&&!countryContestantName.ContainsKey(contestantName))
                {
                    countryNamePoints[country] = 0;
                    countryContestantName[country] = new List<string>();
                }
                if (countryContestantName[country].Contains(contestantName))
                {
                    break;
                }
                countryNamePoints[country] += points;
                countryContestantName[country].Add(contestantName);

            }
        }
    }
}
