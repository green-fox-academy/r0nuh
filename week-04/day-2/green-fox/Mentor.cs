using System;

namespace green_fox
{
    public class Mentor : Person
    {
        string Level { get; set; }

        public Mentor(string name, int age, string gender, string level)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Level = level;
        }
        public Mentor()
        {
            Level = "intermediate";
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2} {3} mentor", Name, Age, Gender, Level);
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Educate brilliant junior software developers.");
        }
    }
}
