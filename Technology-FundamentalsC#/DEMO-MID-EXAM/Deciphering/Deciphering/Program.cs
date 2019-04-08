using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Deciphering
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedString = Console.ReadLine();
            string text = string.Empty;

            var pattern = @"^[d-z{}|#]+$";

            if (Regex.IsMatch(encryptedString,pattern))
            {
                for (int i = 0; i < encryptedString.Length; i++)
                {
                    int symbol = encryptedString[i] - 3;
                    text = text + (char)symbol;
                }

                string twoSubstrings = Console.ReadLine();
                string[] substring = twoSubstrings.Split();
                
                string secondSubstringsb = substring[1];
                foreach (var firstSubstringsb in substring)
                {
                    text = text.Replace(firstSubstringsb, secondSubstringsb);
                }
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("This is not the book you are looking for.");
            }
            
        }
    }
}
