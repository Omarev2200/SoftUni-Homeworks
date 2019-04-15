using System;
using System.Linq;

namespace Santa_s_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var noisyKidsList = Console.ReadLine().Split('&').ToList();

            string commands = string.Empty;
            while ((commands=Console.ReadLine())!= "Finished!")
            {
                string[] comandKid = commands.Split(" ");
                string command = comandKid[0];
                if (command== "Bad")
                {
                    string kidName = comandKid[1];
                    if (!noisyKidsList.Contains(kidName))
                    {
                        noisyKidsList.Insert(0, kidName);
                    }
                }
                if (command== "Good")
                {
                    string kidName = comandKid[1];
                    if (noisyKidsList.Contains(kidName))
                    {
                        noisyKidsList.Remove(kidName);
                    }
                }
                if (command == "Rename")
                {
                    string oldName = comandKid[1];
                    string newName = comandKid[2];
                    if (noisyKidsList.Contains(oldName))
                    {
                        int index = noisyKidsList.IndexOf(oldName);
                        noisyKidsList.RemoveAt(index);
                        noisyKidsList.Insert(index, newName);
                    }
                }
                if (command == "Rearrange")
                {
                    string kidName = comandKid[1];
                    if (noisyKidsList.Contains(kidName))
                    {
                        noisyKidsList.Remove(kidName);
                        noisyKidsList.Add(kidName);
                    }
                }
            }
            
            
                Console.WriteLine(string.Join(", ", noisyKidsList));
            
        }
    }
}
