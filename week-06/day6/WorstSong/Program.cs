// The 100worst.csv file contains the 100 worst singles over 25 years.
// Your task is to check which year produced the most.
// So create the necessary method(s).
// And print out the sentence below with the proper year.
//  `The year when the most worst songs came out is <year>.`

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WorstSong
{
    class Program
    {
        private static readonly string path = @"./100worst.csv";

        static void Main(string[] args)
        {
            string year = WorstYear(path);

            Console.WriteLine($"The year when the most worst songs came out is {year}.");

            Console.Read();
        }

        public static string WorstYear(string path)
        {
            var worstYear = YearsList(path)
                .GroupBy(year => year)
                .OrderByDescending(year => year.Count())
                .First().Key;
               
            return worstYear;
        }
                
        public static List<string> YearsList(string path)
        {
            var yearsList = new List<string>();

            foreach (var line in ReadFile(path))
            {
                string year = line.Split(';').Last<string>();
                yearsList.Add(year);
            }

            return yearsList;
        }

        public static string[] ReadFile(string path)
        {
            try
            {
                return File.ReadAllLines(path);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found!");
            }

            return new string[0];
        }
    }
}
