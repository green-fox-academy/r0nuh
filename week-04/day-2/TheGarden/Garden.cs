using System;
using System.Collections.Generic;
using System.Linq;

namespace TheGarden
{
    class Garden
    {
        public List<Plant> Plants { get; set; }

        public Garden()
        {
            Plants = new List<Plant>();
        }

        public void AddPlant(Plant plant)
        {
            Plants.Add(plant);
        }

        public void GardenCheck()
        {
            foreach (var item in Plants)
            {
                if (item.WaterAmount < item.WaterNeed)
                {
                    Console.WriteLine("The {0} {1} needs water", item.Color, item.Type);
                }
                else
                {
                    Console.WriteLine("The {0} {1} doesnt need water", item.Color, item.Type);
                }
            }
            Console.WriteLine();
        }

        public void Watering (int water)
        {
            Console.WriteLine("Watering with: " + water);

            int watering = water / Plants.Count();

            foreach (var item in Plants)
            {
                item.WaterAmount += (watering * item.Absorb);
            }
        }
    }
}
