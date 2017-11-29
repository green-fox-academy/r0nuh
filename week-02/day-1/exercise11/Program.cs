using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 3;
            // make it bigger by 10

            Console.WriteLine(a *= 10);

            int b = 100;
            // make it smaller by 7

            Console.WriteLine(b -= 7);

            int c = 44;
            // please double c's value

            Console.WriteLine(c *= 2);

            int d = 125;
            // please divide by 5 d's value

            Console.WriteLine(d /= 5);

            int e = 8;
            // please cube of e's value

            Console.WriteLine(e *= e);

            int f1 = 123;
            int f2 = 345;
            // tell if f1 is bigger than f2 (print as a boolean)

            Console.WriteLine(f1 > f2);

            int g1 = 350;
            int g2 = 200;
            // tell if the double of g2 is bigger than g1 (print as a boolean)

            int db = g2 *= 2;
            Console.WriteLine(db > g1);

            long h = 1357988018575474;
            // tell if it has 11 as a divisor (print as a boolean)

            long div = h % 11;
            Console.WriteLine(div == 0);

            int i1 = 10;
            int i2 = 3;
            // tell if i1 is higher than i2 squared and smaller than i2 cubed (print as a boolean)

            int squared = i2 * i2;
            int cubed = i2 * i2 * i2;

            Console.WriteLine(squared < i1 && i1 < cubed);

            int j = 1521;
            // tell if j is dividable by 3 or 5 (print as a boolean)

            int three = j % 3;
            int five = j % 5;

            Console.WriteLine(three == 0 || five == 0);

            string k = "Apple";
            //fill the k variable with its cotnent 4 times

            //k = k + k + k + k;

            Console.WriteLine(k + k + k + k);

            Console.Read();
        }
    }
}