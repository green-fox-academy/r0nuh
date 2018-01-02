using green_fox;
using System;
using System.Collections.Generic;

namespace Cloneable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            Student john = new Student("John Doe", 20, "male", "BME");
            people.Add(john);

            Student johnTheClone = (Student)john.Clone();
            people.Add(johnTheClone);

            foreach (Person person in people)
            {
                person.Introduce();
            }

            Console.Read();
        }
    }
}
