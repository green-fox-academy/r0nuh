using System;

namespace green_fox
{
    public class Sponsor : Person
    {
        public string Company { get; set; }
        public int HiredStudents { get; set; }

        public Sponsor(string name, int age, string gender, string company)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Company = company;
            HiredStudents = 0;
        }

        public Sponsor()
        {
            Company = "Google";
            HiredStudents = 0;
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2} who represents {3} and hired {4} students so far", Name, Age, Gender, Company, HiredStudents);
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Hire brilliant junior software developers.");
        }

        public int Hire()
        {
            return HiredStudents++;
        }
    }
}
