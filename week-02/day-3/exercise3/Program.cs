﻿using System;
using System.Text;

namespace TakesLonger
{
    public class TakesLonger
    {
        public static void Main(string[] args)
        {
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";

            // When saving this quote a disk error has occured. Please fix it.
            // Add "always takes longer than" to the StringBuilder (quote) between the words "It" and "you"
            // Using pieces of the quote variable (instead of just redefining the string)

            StringBuilder fix = new StringBuilder(quote);
            
            int index1 = quote.IndexOf("you");
            fix.Insert(index1, "always takes longer than ");

            Console.WriteLine(fix);
            Console.Read();
        }
    }
}