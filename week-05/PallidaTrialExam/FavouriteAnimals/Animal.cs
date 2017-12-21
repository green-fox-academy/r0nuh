using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavouriteAnimals
{
    class Animal
    {
        string path = @"C:\Users\Szilard\Documents\greenfox\r0nuh\week-05\PallidaTrialExam\FavouriteAnimals\favourites.txt";
        
        public void NoArguments()
        {
            string[] content = File.ReadAllLines(path);
            Console.WriteLine("```C# FavouriteAnimals " + string.Join(" ", content) + " ```");
        }

        public void AddAnimal(string animal)
        {
            string[] content = File.ReadAllLines(path);

            if (!content.Contains(animal))
            {
                StreamWriter writer = new StreamWriter(path, true);
                writer.WriteLine(animal);
                writer.Close();
            }
        }
    }
}
