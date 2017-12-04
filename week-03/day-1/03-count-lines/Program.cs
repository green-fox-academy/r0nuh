using System;
using System.Text;
using System.IO;

namespace _03_count_lines
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that takes a filename as string,
            // then returns the number of lines the file contains.
            // It should return zero if it can't open the file, and
            // should not raise any error.

            string fileName = @"C:\Users\Szilard\Documents\greenfox\r0nuh\week-03\day-1\my-file.txt";

            try
            {
            Console.WriteLine(NumberOfLines(fileName));
            }
            catch (Exception)
            {
                Console.WriteLine("0");
            }
            finally
            {
            Console.Read();
            }
        }
        static int NumberOfLines(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);

            int numberOfLines = lines.Length;

            return numberOfLines;
        }

    }
}
