using System;
using System.Collections.Generic;

namespace green_fox
{
    public class Student : Person
    {
        public string PreviousOrganization { get; set; }
        public int SkippedDays { get; set; }

        public Student(string name, int age, string gender, string previousOrganization)
        {
            Name = name;
            Age = age;
            Gender = gender;
            PreviousOrganization = previousOrganization;
            SkippedDays = 0;
        }

        public Student()
        {
            PreviousOrganization = "The School of Life";
            SkippedDays = 0;
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2} from {3} who skipped {4} days from the course already.", Name, Age, Gender, PreviousOrganization, SkippedDays);
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Be a junior software developer.");
        }

        public void SkipDays( int numberOfDays)
        {
            SkippedDays += numberOfDays;
        }
    }
}
