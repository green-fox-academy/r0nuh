using System;

namespace TheGarden
{
    internal class Tree : Plant
    {
        public Tree(string color, double waterAmount) : base(color, waterAmount)
        {
            Absorb = 0.4;
            Type = "Tree";
            WaterNeed = 10;
        }
    }
}
