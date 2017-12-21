using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeMeToThe
{
    class CandyShop
    {
        public double Income { get; set; }
        public double Sugar { get; set; }
        public List<string> Inventory { get; set; }

        public CandyShop(double sugar)
        {
            Sugar = sugar;
            Income = 0;
            Inventory = new List<string>();
        }

        public void CreateSweets(Candy candy)
        {
            
            Inventory.Add(candy.ToString());
        }

        public void PrintInfo()
        {
            foreach (var item in Inventory)
            {
                Console.WriteLine(item);
            }
        }
    }
}
