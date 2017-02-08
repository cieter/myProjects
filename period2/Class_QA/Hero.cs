using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_QA
{
    class Hero : Player
    {
        public Hero(string name)
            : base(name)
        {

        }

        public override void Kill()
        {
            Console.WriteLine("Could not kill boss, boss is flying too high...");
        }
    }
}
