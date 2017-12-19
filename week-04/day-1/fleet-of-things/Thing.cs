using System;

namespace FleetOfThings
{
    public class Thing
    {
        public string Name { get; set; }
        public bool Completed { get; set; }

        public Thing(string name)
        {
            this.Name = name;
            this.Completed = false;
        }

        public void Complete()
        {
            this.Completed = true;
        }
    }
}