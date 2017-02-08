using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class Pet
    {
        protected int legs;
        protected int withers;
        protected int weight;

        protected string name;
        protected string gender;
        protected string color;
        protected string race;
        protected string cry;

        public Pet(string name, string race)
        {
            this.name = name;
            this.race = race;
        }

        public void Move()
        {
            Console.WriteLine("I am moving");
        }

        public void Cry()
        {
            Console.WriteLine("I am making a sound right now.");
        }

        public virtual void Describe()
        {
            Console.WriteLine("I am a pet, my name is {0}, I am a {1}", this.name, this.race);
        }
    }
}
