using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Write a function called `sum` that sum all the numbers
            //   until the given parameter
            int x = 6;

            Sum(x);
            Console.ReadLine();
        }

        static void Sum(int x)
        {
            int j = 0;
            for(int i = 0; i < x; i++)
            {
                j += i;
            }
            Console.WriteLine(x + j);
        }
    }
}