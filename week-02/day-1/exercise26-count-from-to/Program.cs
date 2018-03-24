﻿using System;

namespace exercise26_count_from_to
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5

            Console.WriteLine("Give two numbers");

            Console.Write("first number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("second number: ");
            int number2 = int.Parse(Console.ReadLine());

            if (number1 > number2)
            {
                Console.WriteLine("The second number should be bigger");
                Console.Write("second number: ");
                number2 = int.Parse(Console.ReadLine());
            }

            for (int i = number1; i <= number2; ++i)
            {
                Console.WriteLine(i);
            }

            Console.Read();
        }
    }
}
