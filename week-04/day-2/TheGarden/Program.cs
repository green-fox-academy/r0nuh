using System;

namespace TheGarden
{
    class Program
    {
        static void Main(string[] args)
        {
            var garden = new Garden();

            garden.Plants.Add(new Flower("yellow", 1));
            garden.Plants.Add(new Flower("blue", 1));
            garden.Plants.Add(new Tree("orange", 1));
            garden.Plants.Add(new Tree("purple", 1));

            garden.GardenCheck();

            garden.Watering(40);

            garden.GardenCheck();

            garden.Watering(70);

            garden.GardenCheck();

            Console.Read();
        }
    }
}
