using System;
using System.IO;

namespace _06_copy_file
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful

            string fileFrom = @"C:\Users\Szilard\Documents\greenfox\r0nuh\week-03\day-1\my-file.txt";
            string fileTo = @"C:\Users\Szilard\Documents\greenfox\r0nuh\week-03\day-1\my-file-copy.txt";

            //try 
	        //{	        
            Console.WriteLine(Copy(fileFrom, fileTo));
            

            Console.Read();
	        //}
	        //finally
	        //{
          
        }
        static bool Copy(string path1, string path2)
        {
            string content = File.ReadAllText(path1);

            if(content != null) 
            {
            File.WriteAllText(path2, content);
            return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
