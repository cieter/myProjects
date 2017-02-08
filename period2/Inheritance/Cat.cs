using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Inheritance
{
    class Cat : Pet
    {
        int lives;
        public Cat(string name, string race, int weight)
            : base(name, race)
        {
            this.weight = weight;
            this.lives = 9;
        }



        public Cat(string name, string race, int weight, int lives)
            : base(name, race)
        {
            this.weight = weight;
            this.lives = 9;
        }

        public override void Describe()
        {
            Console.WriteLine("I am a cat, my name is {0}, and I am a {1}, I weigh {2}. I has {3} lives", this.name, this.race, this.weight, this.lives);
        }

        public void Climb()
        {
            Console.WriteLine("I am climbing.");
        }

        public void Fall()
        {
            Random chance = new Random();
            int fell = chance.Next(0, 2);
            Console.WriteLine(fell);
            Thread.Sleep(1000);
            
        }        
    }
}
