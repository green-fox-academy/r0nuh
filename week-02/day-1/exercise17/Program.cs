using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4

            //string[] input = 
            int number0 = Convert.ToInt32(Console.ReadLine());
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());
            int number4 = Convert.ToInt32(Console.ReadLine());


            int sum = number0 + number1 + number2 + number3 + number4;
            int avg = sum / 5;

            Console.WriteLine("Sum: " + sum + "," + "Average: " + avg);
            Console.Read();
        }
    }
}