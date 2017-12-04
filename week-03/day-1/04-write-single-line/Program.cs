using System;
using System.IO;

namespace _04_write_single_line
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open a file called "my-file.txt"
            // Write your name in it as a single line
            // If the program is unable to write the file,
            // then it should print an error message like: "Unable to write file: my-file.txt"

            string path = @"C:\Users\Szilard\Documents\greenfox\r0nuh\week-03\day-1\my-file.txt";

            using (StreamWriter writer = new StreamWriter(path, true)) 
            {
                writer.WriteLine("Szilard Csiki");
            }
        }
    }
}
