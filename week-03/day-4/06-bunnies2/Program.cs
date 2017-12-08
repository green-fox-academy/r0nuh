﻿using System;

namespace _06_bunnies2
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have bunnies standing in a line, numbered 1, 2, ... The odd bunnies
            // (1, 3, ..) have the normal 2 ears. The even bunnies (2, 4, ..) we'll say
            // have 3 ears, because they each have a raised foot. Recursively return the
            // number of "ears" in the bunny line 1, 2, ... n (without loops or multiplication).

            Console.WriteLine(NumberOfEars(9, 2));
            Console.Read();
        }
        static int NumberOfEars(int bunnies, int ears)
        {
            int evenears = ears + 1;
            if (bunnies > 1 && bunnies % 2 != 0)
            {
                bunnies--;
                return NumberOfEars(bunnies, ears) + ears;
            }
            else if (bunnies > 1 && bunnies % 2 == 0)
            {
                bunnies--;
                return NumberOfEars(bunnies, ears) + evenears;
            }
            else
            {
                return ears;
            }
        }
    
    }
}
