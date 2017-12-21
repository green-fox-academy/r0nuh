using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavouriteAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            // The program's aim is to collect your favourite animals and store them in a text file.
            // There is a given text file called '''favourites.txt''', it will contain the animals
            // If ran from the command line without arguments
            // It should print out the usage:
            // ```C# FavouriteAnimals [animal] [animal]```
            // You can add as many command line arguments as many favourite you have.
            // One animal should be stored only at once
            // Each animal should be written in separate lines
            // The program should only save animals, no need to print them

            var animal = new Animal();

            if (args.Length > 0)
                for (int i = 0; i < args.Length; i++)
                {
                    animal.AddAnimal(args[i]);
                }
            else
                animal.NoArguments();

            //Console.Read();
        }
    }
}
