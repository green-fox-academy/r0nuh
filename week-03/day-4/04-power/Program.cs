using System;

namespace _04_power
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given base and n that are both 1 or more, compute recursively (no loops)
            // the value of base to the n power, so powerN(3, 2) is 9 (3 squared).

            Console.WriteLine(PowerN(2, 10));
            Console.Read();
        }

        public static int PowerN(int number, int power)
        {
            
            if (power > 1)
            {
                power--;
                int result = PowerN(number, power) * number;
                return result;
            }
            else
            {
                return number;
            }
        }
    }
}
