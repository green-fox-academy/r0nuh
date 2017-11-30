using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The seconf represents the number of pigs the farmer has
            // It should print how many legs all the animals have

            Console.Write("chikens: ");
            int chickens = Convert.ToInt32(Console.ReadLine());

            Console.Write("pigs: ");
            int pigs = Convert.ToInt32(Console.ReadLine());

            int legs = chickens * 2 + pigs * 4;

            Console.WriteLine("number of legs: " + legs);
            Console.Read();
        }
    }
}