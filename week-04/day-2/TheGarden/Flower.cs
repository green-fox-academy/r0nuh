using System;

namespace TheGarden
{
    class Flower : Plant
    {
        public Flower(string color, double waterAmount) : base(color, waterAmount)
        {
            Absorb = 0.75;
            Type = "Flower";
            WaterNeed = 5;
        } 
    }
}
