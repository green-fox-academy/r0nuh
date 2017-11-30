using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented bt the variables

            int dayInSeconds = 60 * 60 * 24;
            int currentInSeconds = (currentHours * 60 * 60) + (currentMinutes * 60) + currentSeconds;

            Console.WriteLine(dayInSeconds - currentInSeconds);
            Console.Read();
        }
    }
}