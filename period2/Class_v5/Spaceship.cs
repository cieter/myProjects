using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_v5
{
    abstract class Spaceship
    {
        protected string name;
        protected int health;

        public Spaceship(string name)
        {
            this.name = name;
        }

        public Spaceship(string name, int health)
        {
            this.name = name;
            this.health = health;
        }

        abstract public void Move();

        virtual public int TakeDamage(int damage)
        {
            return this.health -= damage;
        }
        
    }
}
