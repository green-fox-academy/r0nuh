﻿using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that prints a few details to the terminal window about you
            // It should print each detail to a new line.
            //  - Your name
            //  - Your age
            //  - Your height in meters (as a decimal fraction)
            //
            //  Example output:
            //  John Doe
            //  31
            //  1.87

            Console.WriteLine("My name is Szilard Csiki");
            Console.WriteLine("I'm " + 34 + " years old");
            Console.WriteLine("My height is " + 1.72 + " meters");

            Console.Read();
        }
    }
}