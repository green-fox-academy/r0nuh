using System;

namespace exercise29_draw_pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //
            // The pyramid should have as many lines as the number was

            Console.Write("Give a number: ");
            int lines = int.Parse(Console.ReadLine());
            int star = 2 * lines - 1;
            int gap = lines--;

            for (int i = 0; i <= lines++; i += 2)
            {
                for (int j = 0; j <= i; ++j)
                {
                    if (j < gap)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }

                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
