using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one

            Console.WriteLine("Write two numbers: ");
            int number0 = Convert.ToInt32(Console.ReadLine());
            int number1 = Convert.ToInt32(Console.ReadLine());

            if (number0 > number1)
            {
                Console.WriteLine(number0 + " is the bigger one");
            }
            else if (number0 < number1)
            {
                Console.WriteLine(number1 + " is the bigger one");
            }
            else
            {
                Console.WriteLine("They are equal");
            }

            Console.Read();
        }
    }
}