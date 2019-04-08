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
           
            while ((commands=Console.ReadLine()) !="END")
            {
                string[] command = commands.Split().ToArray();

                if (command[0]== "Change")
                {
                    int paintingNumber = int.Parse(command[1]);
                    int changedNumber= int.Parse(command[2]);
                    if (numbersOfThePaintings.Contains(paintingNumber))
                    {
                        int index = numbersOfThePaintings.IndexOf(paintingNumber);
                        numbersOfThePaintings[index] = changedNumber;
                    }
                }
                if (command[0]== "Hide")
                {
                    int paintingNumber = int.Parse(command[1]);
                    if (numbersOfThePaintings.Contains(paintingNumber))
                    {
                        numbersOfThePaintings.Remove(paintingNumber);
                    }
                }
                if (command[0] == "Switch")
                {
                    int paintingNumber = int.Parse(command[1]);
                    int paintingNumber2 = int.Parse(command[2]);
                    if (numbersOfThePaintings.Contains(paintingNumber) && numbersOfThePaintings.Contains(paintingNumber2))
                    {
                        int index1 = numbersOfThePaintings.IndexOf(paintingNumber);
                        int index2 = numbersOfThePaintings.IndexOf(paintingNumber2);


                        numbersOfThePaintings[index1] = paintingNumber2;
                        numbersOfThePaintings[index2] = paintingNumber;

                    }
                }
                if (command[0] == "Insert")
                {
                    int place = int.Parse(command[1]);
                    int paintingNumber = int.Parse(command[2]);
                    
                    if ((numbersOfThePaintings.Count >= place+1 ) && (place+1>= 0))
                    {

                        numbersOfThePaintings.Insert(place+1, paintingNumber);
                    }
                }
                if (command[0] == "Reverse")
                {
                    
                    numbersOfThePaintings.Reverse();
                }
            }
            Console.WriteLine(String.Join(" ",numbersOfThePaintings));
        }
    }
}
