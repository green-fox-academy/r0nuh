using System;


namespace _03_sumdigit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a non-negative int n, return the sum of its digits recursively (no loops). 
            // Note that mod (%) by 10 yields the rightmost digit (126 % 10 is 6), while 
            // divide (/) by 10 removes the rightmost digit (126 / 10 is 12).

            Console.WriteLine(SumDigit(1222));
            Console.Read();
        }
        public static int SumDigit(int n)
        {
            if (n < 10)
            {
                return n;
            }
            else
            {
                return SumDigit(n / 10) + SumDigit(n % 10);
            }
        }
    }
}
