using System;
using System.IO;


namespace _02_print_each_line
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that opens a file called "my-file.txt", then prints
            // each of lines from the file.
            // If the program is unable to read the file (for example it does not exists),
            // then it should print an error message like: "Unable to read file: my-file.txt"

            try
            {
            string content = File.ReadAllText(@"C:\Users\Szilard\Documents\greenfox\my-file.txt");
                Console.WriteLine(content);
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to read file: my-file.txt");
            }
            finally
            {
            Console.Read();
            }
        }
    }
}
