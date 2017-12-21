using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueChars
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method called `UniqueCharacters` that takes a string as parameter
            // and returns a list with the unique letters of the given string ("anagram")
            // Create basic unit tests for it with at least 3 different test cases
            // Print the characters from that list in the following format:
            // "n", "g", "r", "m"

            Print(UniqueCharacters("alma"));

            Console.Read();
        }

        public static List<char> UniqueCharacters(string param)
        {
            List<char> letters = new List<char>();

            char[] characters = param.ToCharArray();
            //Array.Sort(characters);

            for (int i = 0; i < characters.Length; i++)
            {
                foreach (var letter in characters)
                {
                    if (letter != characters[i])
                        letters.Add(letter);
                }
                //for (int j = 0; j < characters.Length; j++)
                //{
                //    if (i != j && characters[i] == characters[j]) { }

                //    else if (i != j && characters[i] != characters[j])
                //        {
                //        //if (characters[i] != characters[j])
                //            letters.Add(characters[j]);
                //    }
                
              
                {
                }
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
