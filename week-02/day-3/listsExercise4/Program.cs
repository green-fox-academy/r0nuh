using System;
using System.Collections.Generic;

namespace CandyShop
{
    public class Candyshop
    {
        public static void Main(string[] args)
        {
            var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);

            // Accidentally we added "2" and "false" to the list. 
            // Your task is to change from "2" to "Croissant" and change from "false" to "Ice cream"
            // No, don't just remove the lines

            /*
             * // First solution:
            list[1] = "Croissant";
            list[3] = "Ice cream";
            */

            list.Insert(list.IndexOf(2),"Croissant");
            list.Remove(2);

            list.Insert(list.IndexOf(false), "Ice cream");
            list.Remove(false);

            foreach (var item in list)
            {
            Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
