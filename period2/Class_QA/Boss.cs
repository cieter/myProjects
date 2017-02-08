using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_QA
{
    class Boss : Player
    {
        public Boss(string name)
            : base(name)
        {

        }

        public void Fly()
        {
            Console.WriteLine("I believe I can fly...");
        }

        public override void Kill()
        {
            Console.WriteLine("Silence... I kill you!!!");
        }
    }
}
