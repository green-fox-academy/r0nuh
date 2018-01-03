using System;
using System.Linq;

namespace FrequencyOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var frequencyOfNumbers = from number in n
                                     group number by number;

            foreach (var group in frequencyOfNumbers)
            {
                Console.WriteLine($"The number of {group.Key}'s in the array is: {group.Count()}");
                //foreach (var item in group)
                //{
                //    Console.Write("  " + item);
                //}
                //Console.WriteLine();
            }
            Console.WriteLine();

            var frequencyOfNumbersWithLambda = n.GroupBy(i => i).ToDictionary(i => i.Key, i => i.Count());

            foreach (var item in frequencyOfNumbersWithLambda)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            Console.Read();
        }
    }
}
