using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Swap the values of the variables
            int a = 123;
            int b = 526;

            int c = a + b;
            Console.WriteLine(a = c - a);
            Console.WriteLine(b = c - b);
            Console.Read();
        }
    }
}