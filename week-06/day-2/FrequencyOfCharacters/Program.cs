using System;
using System.Linq;

namespace FrequencyOfCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string givenString = "Exercise";

            var frequencyOfCharacters = from character in givenString
                                     group character by character;

            foreach (var group in frequencyOfCharacters)
            {
                Console.WriteLine($"The number of {group.Key}'s in the string is: {group.Count()}");
            }
            Console.WriteLine();

            var frequencyOfCharactersWithLambda = givenString.GroupBy(s => s).ToDictionary(s => s.Key, s => s.Count());

            foreach (var item in frequencyOfCharactersWithLambda)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            Console.Read();
        }
    }
}
