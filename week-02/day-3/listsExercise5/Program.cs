using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementFinder
{
    public class ElementFinder
    {
        public static void Main(string[] args)
        {
            var List = new List<int> { 1, 2, 3, 4, 5, 7 };

            // Check if the arrayList contains "7" if it contains print "Hoorray" otherwise print "Noooooo"
            // Do this again with a different solution using different list functions!

            CheckForSeven(List);
            CheckFor7(List);
            CheckSeven(List);

            Console.Read();
        }

        static void CheckForSeven(List<int> list)
        {
            if (list.Contains(7))
                Console.WriteLine("Hoorray");
            else
                Console.WriteLine("Noooooo");
        }

        static void CheckFor7(List<int> list)
        {
            if (list.Exists(element => element == 7))
                Console.WriteLine("Hoorray");
            else
                Console.WriteLine("Noooooo");
        }

        static void CheckSeven(List<int> list)
        {
            int seven = list.Find(element => element == 7);

            if (seven == 7)
                Console.WriteLine("Hoorray");
            else
                Console.WriteLine("Noooooo");
        }
    }
}
