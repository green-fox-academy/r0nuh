using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000

            int a = 1;
            int b = 2;
            int c = 3;

            int volume = a * b * c;
            int area = 2 * (a * b + a * c + b * c);

            Console.WriteLine("Surface Area: " + area);
            Console.WriteLine("Volume: " + volume);
            Console.Read();
        }
    }
}