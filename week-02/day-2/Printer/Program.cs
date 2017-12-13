using System;

namespace Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `printer`
            //   which prints the input String parameters
            // - It can have any number of parameters


            Printer("first", "second", "third");
            Console.Read();
        }
        static void Printer(params string[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {

            Console.WriteLine(input[i]);
            }
        }
    }
}
