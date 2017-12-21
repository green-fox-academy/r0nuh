using System;
using System.Collections.Generic;

namespace UniqueChars
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a method called `UniqueCharacters` that takes a string as parameter
            // and returns a list with the unique letters of the given string ("anagram")
            // Create basic unit tests for it with at least 3 different test cases
            // Print the characters from that list in the following format:
            // "n", "g", "r", "m"

            Print(UniqueCharacters("anagram"));

            Console.Read();
        }

        public static List<char> UniqueCharacters(string param)
        {
            List<char> letters = new List<char>();

            char[] characters = param.ToCharArray();

            for (int i = 0; i < characters.Length; i++)
            {
                int n = 0;
                
                for (int j = 0; j < characters.Length; j++)
                {
                    if (characters[i] == characters[j])
                        n++;
                }
                if (n < 2)
                    letters.Add(characters[i]);
            }
            return letters;
        }
        public static void Print(List<char> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                Console.Write("\"" + list[i] + "\"" + ",");
            }
            Console.Write("\"" + list[list.Count - 1] + "\"");
        }
    }
}
