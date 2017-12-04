using System;
using System.IO;
using System.Text;

namespace _05_write_multiple_lines
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes 3 parameters: a path, a word and a number,
            // than it should write to a file.
            // The path parameter should be a string, that describes the location of the file.
            // The word parameter should be a string, that will be written to the file as lines
            // The number paramter should describe how many lines the file should have.
            // So if the word is "apple" and the number is 5, than it should write 5 lines
            // to the file and each line should be "apple"
            // The function should not raise any error if it could not write the file.

            try 
            {
            Writer();
            }
            catch (Exception e) 
            {
                Console.WriteLine("");
            }
            finally 
            {
                Console.WriteLine("Done!");
                Console.Read();
            }

        }
        static void Writer() 
        {
            string path = @"C:\Users\Szilard\Documents\greenfox\r0nuh\week-03\day-1\multiple-lines.txt";

            Console.Write("Give a word: ");
            string word = Console.ReadLine();

            Console.Write("Give a number: ");
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine(word);
                }
            }
        }
    }
}
