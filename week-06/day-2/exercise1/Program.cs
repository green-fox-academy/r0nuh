using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var evenNumbers = from numbers in n
                              where numbers % 2 == 0
                              select numbers;

            foreach (var number in evenNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            IEnumerable<int> evenNumbersWithLambda = n.Where(i => i % 2 == 0);

            foreach (var num in evenNumbersWithLambda)
            {
                Console.Write(num + " ");
            }

            Console.Read();
        }
    }
}
