using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaredNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var positiveNumbers = from numbers in n
                              where numbers > 0
                              select numbers * numbers;

            foreach (var number in positiveNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            IEnumerable<int> positiveNumbersWithLambda = n.Where(i => i > 0).Select(i => i * i);

            foreach (var num in positiveNumbersWithLambda)
            {
                Console.Write(num + " ");
            }

            Console.Read();
        }
    }
}
