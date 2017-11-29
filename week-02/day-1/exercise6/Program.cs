using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            // An average Green Fox attendee codes 6 hours daily
            // The semester is 17 weeks long

            int hours = 6;
            int weeks = 17;
            
            //
            // Print how many hours is spent with coding in a semester by an attendee,
            // if the attendee only codes on workdays.
            Console.WriteLine(5 * hours * weeks);
            //
            // Print the percentage of the coding hours in the semester if the average
            // work hours weekly is 52
            double percentage;
            percentage = (hours * 5) / 52 * 100;
            Console.WriteLine(percentage + "%");

            Console.Read();

        }
    }
}
