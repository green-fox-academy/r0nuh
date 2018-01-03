using System;
using System.Linq;

namespace UppercaseChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string givenString = "ExeRcise";

            var uppercaseCharacters = from character in givenString
                                      where character.ToString() == character.ToString().ToUpper()
                                      select character;

            foreach (var character in uppercaseCharacters)
            {
                Console.WriteLine(character);
            }
            Console.WriteLine();

            var uppercaseCharactersWithLambda = givenString.Where(c => c.ToString().Equals(c.ToString().ToUpper()));

            foreach (var character in uppercaseCharactersWithLambda)
            {
                Console.Write(character + " ");
            }

            Console.Read();
        }
    }
}
