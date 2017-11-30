using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for an integer that is a distance in kilometers,
            // then it converts that value to miles and prints it

            //Console.Write("km: ");
            int km = Convert.ToInt32(Console.Read());

            Console.WriteLine(km * 0.621371);
            Console.ReadLine();
        }
    }
}