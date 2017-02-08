using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_v5
{
    class Fighter : Spaceship
       
    {
        private int guns = 4;
        private int ammo = 200;

        public Fighter(string name)
            : base(name)
        {

        }

        public Fighter(string name, int health)
            : base(name, health)
        {

        }

        public override void Move()
        {

        }

        public int Shoot(int guns, int ammo)
        {
            return this.guns -= this.ammo;
        }
    }
}
