using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores a number, and the user has to figure it out.
            // The user can input guesses, after each guess the program would tell one
            // of the following:
            //
            // The stored number is higher
            // The stried number is lower
            // You found the number: 8

            int x = 33;
            int guess = 0;

            while (guess != x)
            {
                Console.Write("Guess the number between 0 and 1000: ");
                guess = Convert.ToInt16(Console.ReadLine());

                if (guess > x)
                {
                    Console.WriteLine("The stored number is lower");
                }
                else if (guess < x)
                {
                    Console.WriteLine("The stored number is higher");
                }
            }

            Console.WriteLine("You found the number: {0}", x);            
            Console.Read();
            
        }
    }
}