using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_divide_by_zero
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a function that takes a number
            // divides ten with it,
            // and prints the result.
            // it should print "fail" if the parameter is 0

            try
            {
            Divide10();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("FAIL");
            }
            finally
            {
                Console.Read();
            }


        }
        static void Divide10()
        {
            Console.Write("Divide 10 with: ");
            int divisor = int.Parse(Console.ReadLine());

            int x = 10;

            Console.WriteLine("The result is: " + x / divisor);
            Console.Read();
        }
    }
}
