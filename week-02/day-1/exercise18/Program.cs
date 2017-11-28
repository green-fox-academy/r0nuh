using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number form the standard input,
            // Than prints "Odd" if the number is odd, or "Even" it it is even.
            Console.Write("Write a number between 0 and 1000: ");
            int number = Convert.ToInt16(Console.ReadLine());
            int result = number % 2;

            if (result == 0)
            {
                Console.WriteLine("It is Even");
            }
            else
            {
                Console.WriteLine("It is Odd");
            }
            Console.Read();
        }
    }
}