using System;

namespace Animal
{
    class Animal
    {
        public int Hunger { get; set; }
        public int Thirst { get; set; }
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
            Hunger = 50;
            Thirst = 50;
        }

        public void Eat()
        {
            Hunger--;
        }

        public void Drink()
        {
            Thirst--;
        }

        public void Play()
        {
            Hunger++;
            Thirst++;
        }
    }
}
