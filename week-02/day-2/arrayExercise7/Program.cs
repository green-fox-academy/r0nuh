using System;

namespace DiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create (dynamically) a two dimensional array
            //   with the following matrix. Use a loop!
            //
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            //
            // - Print this two dimensional array to the output

            Console.Write("Give the parameter of the equal size matrix: ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++) 
                {
                    if (x==y) 
                    {
                        Console.Write("1 ");
                    }
                    else 
                    {
                        Console.Write("0 ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}