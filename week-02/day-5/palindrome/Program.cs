using System;
using System.Linq;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            CreatePalindrome();

        }
        static void CreatePalindrome()
        {
            Console.WriteLine("Give a word:");
            string input = Console.ReadLine();

            string reverse = new string(input.ToCharArray().Reverse().ToArray());

            Console.WriteLine(input + reverse);
            Console.Read();
        }
    }
}
