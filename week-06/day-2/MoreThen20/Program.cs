using System;
using System.Collections.Generic;
using System.Linq;

namespace MoreThen20
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new[] { 3, 9, 2, 8, 6, 5 };

            var squaredNumbers = from numbers in n
                                 where (numbers * numbers) > 20
                                 select numbers;

            foreach (var number in squaredNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            IEnumerable<int> squaredNumbersWithLambda = n.Where(i => (i * i) > 20);

            foreach (var num in squaredNumbersWithLambda)
            {
                Console.Write(num + " ");
            }

            Console.Read();
        }
    }
}
