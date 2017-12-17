﻿using System;
using System.Collections.Generic;

namespace IsInList
{
    public class IsInList
    {
        public static void Main(string[] args)
        {
            var list = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16 };

            // Check if list contains all of the following elements: 4,8,12,16
            // Print "true" if it contains all, otherwise print "false"
            // Can you do both the different approaches you tried in the previous one?

            Console.WriteLine(list.Contains(4) && list.Contains(8) && list.Contains(12) && list.Contains(16));

            Console.WriteLine(list.IndexOf(4) != -1 && list.IndexOf(8) != -1 && list.IndexOf(12) != -1 && list.IndexOf(16) != -1);

            Console.Read();
        }
    }
}
