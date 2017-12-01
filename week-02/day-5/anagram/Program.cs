using System;
using System.Linq;

namespace anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Anagram();

        }
        static void Anagram()
        {
            Console.WriteLine("Give two words:");
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            string reverse2 = new string(input2.ToCharArray().Reverse().ToArray());

            Console.WriteLine(String.Equals(input1, reverse2));
            Console.Read();

        }
    }
}
