using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_v5
{
    class Cargoship : Spaceship
    {
        private int maxCapacity;
        private List<Cargo> cargo;

        public Cargoship(string name, int  maxCapacity)
            : base(name)
        {
            this.maxCapacity = maxCapacity;
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }

        public void Load(Cargo[] cargo)
        {
            int weight = 0;

            for (int i = 0; i < cargo.Length; i++)
            {
                weight += cargo[i].weight;
            }

            if (weight <= this.maxCapacity)
            {
                this.cargo.AddRange(cargo);
            }
            else
            {
                Console.WriteLine("No cargo space left.");
            }
        }

        public void UnLoad(Cargo[] cargo)
        {
            for (int i = 0; i < cargo.Length; i++)
            {

            }
        }


    }
}
