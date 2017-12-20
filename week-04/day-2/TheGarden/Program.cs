using System;

namespace TheGarden
{
    class Program
    {
        static void Main(string[] args)
        {
            var garden = new Garden();

            garden.AddPlant(new Flower("yellow", 1));
            garden.AddPlant(new Flower("blue", 1));
            garden.AddPlant(new Tree("orange", 1));
            garden.AddPlant(new Tree("purple", 1));

            garden.GardenCheck();

            garden.Watering(40);

            garden.GardenCheck();

            garden.Watering(70);

            garden.GardenCheck();

            Console.Read();
        }
    }
}
