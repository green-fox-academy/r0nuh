using System;

namespace _05_bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have a number of bunnies and each bunny has two big floppy ears.
            // We want to compute the total number of ears across all the bunnies recursively (without loops or multiplication).

            Console.WriteLine(NumberOfEars(33, 2));
            Console.Read();
        }
        static int NumberOfEars(int bunnies, int ears)
        {
            if (bunnies > 1)
            {
                bunnies--;
                return NumberOfEars(bunnies, ears) + ears;
            }
            else
            {
                return ears;
            }
        }
    }
}
