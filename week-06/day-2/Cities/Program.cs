using System;
using System.Collections.Generic;
using System.Linq;

namespace Cities
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var citiesWithAI = from city in cities
                               where city.StartsWith("A") && city.EndsWith("I")
                               select city;

            foreach (var city in citiesWithAI)
            {
                Console.WriteLine(city);
            }

            var citiesWithAIWithLambda = cities.Where(city => city.StartsWith("A") && city.EndsWith("I"));

            foreach (var city in citiesWithAIWithLambda)
            {
                Console.WriteLine(city);
            }

            Console.Read();
        }
    }
}
