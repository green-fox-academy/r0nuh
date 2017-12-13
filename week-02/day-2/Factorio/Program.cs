using System;

namespace Factorio
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `factorio`
            //   that returns it's input's factorial

            Console.WriteLine(Factorio(5));
            Console.ReadLine();
        }

        static int Factorio(int x)
        {
            int fact = 1;
            if (x > 0)
            {
                for (int i = 1; i <= x; i++)
                {
                    fact *= i;
                }
                return fact;
            }
            else
            {
                return fact;
            }
        }
    }
}
