using System;

namespace TheGarden
{
    class Plant
    {
        public string Color { get; set; }
        public double WaterAmount { get; set; }
        public string Type { get; set; }
        public double Absorb { get; set; }
        public double WaterNeed { get; set; }

        public Plant(string color, double waterAmount)
        {
            Color = color;
            WaterAmount = waterAmount;  
        }
    }
}
