using System;


namespace _02_numberadder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a recursive function that takes one parameter: n and adds numbers from 1 to n.

            Console.WriteLine(NumberAdder(5));
            Console.Read();
        }
        public static int NumberAdder(int n)
        {
            if (n > 0)
            {
                return n + NumberAdder(n - 1); 
            }
            else
            {
                return 0;
            }
        }
    }
}
