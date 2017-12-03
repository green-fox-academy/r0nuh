using System;

namespace SwapElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `abc`
            //   with the following content: `["first", "second", "third"]`
            // - Swap the first and the third element of `abc`

            string[] abc = new string[] { "first", "second", "third" };

            foreach (string element in abc)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            string temp = abc[0];
            abc[0] = abc[2];
            abc[2] = temp;

            foreach(string element in abc)
            {
            Console.Write(element + " ");
            }

            Console.ReadLine();
        }
    }
}