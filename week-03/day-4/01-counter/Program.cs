using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_counter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a recursive function that takes one parameter: n and counts down from n.
            CountDown(20);
            Console.Read();
        }
        static void CountDown(int n)
        {
            if (n >= 0)
            {
                Console.WriteLine(n);
                CountDown(n - 1);
            }
        }
    }
}
