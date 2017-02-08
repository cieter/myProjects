using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_v5
{
    class Program
    {
        static void Main(string[] args)
        {
            Cargo gold = new Cargo(40, 40000);
            Cargo iron = new Cargo(500, 500);

            Cargoship cargoship = new Cargoship("Colossus", 100000);

            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
