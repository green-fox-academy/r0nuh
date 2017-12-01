using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anagram
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Give two words:");
            string input1 = Console.ReadLine();
            string reverse1 = new string(input1.ToCharArray().Reverse().ToArray());

            string input2 = Console.ReadLine();
            string reverse2 = new string(input2.ToCharArray().Reverse().ToArray());

            //char[] input1array = input1.ToCharArray();
            Console.WriteLine(input2);
            Console.Read();
        }
    }
}
