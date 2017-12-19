using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal("cat");

            Print(cat);

            cat.Eat();
            cat.Eat();
            cat.Eat();
            cat.Eat();
            cat.Play();

            Print(cat);

            Console.Read();
        }

        static void Print(Animal animal)
        {
            Console.WriteLine("{0}'s hunger:{1}", animal.Name, animal.Hunger);
            Console.WriteLine("{0}'s hunger:{1}", animal.Name, animal.Thirst);
            Console.WriteLine();
        }
    }
}
