using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that prints a few operations on two numbers: 22 and 13

            int number1;
            int number2;

            number1 = 13;
            number2 = 22;

            // Print the result of 13 added to 22
            Console.WriteLine(value: number2 + number1);

            // Print the result of 13 substracted from 22
            Console.WriteLine(value: number2 - number1);

            // Print the result of 22 mutiplied by 13
            Console.WriteLine(value: number2 * number1);


            // Print the result of 22 divided by 13 (as a decimal fraction)
          
            Console.WriteLine(value: number2 / (double)number1);

            // Print the integer part of 22 divided by 13
            Console.WriteLine(value: number2 / number1);

            // Print the reminder of 22 divided by 13
            Console.WriteLine(value: number2 % number1);

            Console.ReadLine();
        }
    }
}
