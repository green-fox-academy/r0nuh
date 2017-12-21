using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeMeToThe
{
    class Candy : Sweets
    {
        public Candy(string type) : base(type)
        {
            Price = 20;
            SugarNeed = 10;
            Type = "CANDY";
        }
    }
}
