using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Dog : Pet
    {
        public Dog(string name, string race, int withers)
            :base(name, race)
        {
            this.withers = withers;
        }
        public override void Describe()
        {
            Console.WriteLine("I am a dog, my name is {0}, and I am a {1}, I am {2} centimeters tall.", this.name, this.race, this.withers);
        }
    }
}
