using System;
using System.Linq;

namespace anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            IsAnagram();

        }
        static void IsAnagram()
        {
            Console.WriteLine("Give two words:");
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            if (input1.Length == input2.Length)
            {
                char[] elementsOfInput1 = input1.ToCharArray();
                Array.Sort(elementsOfInput1);
                string sortedInput1 = new string(elementsOfInput1);

                char[] elementsOfInput2 = input2.ToCharArray();
                Array.Sort(elementsOfInput2);
                string sortedInput2 = new string(elementsOfInput2);
                
                Console.WriteLine("Are these two words anagrams? " + String.Equals(sortedInput1, sortedInput2));
            }
            else
            {
            Console.WriteLine("Are these two words anagrams? " + String.Equals(input1, input2));
            }
            Console.Read();

        }
    }
}
