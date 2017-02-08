using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Hans", "Golden Retriever", 50);

            dog.Describe();


            Cat cat = new Cat("Mittens", "Persian", 5);

            cat.Describe();
            cat.Climb();

            for (int i = 0; i < 10; i++)
            {
                cat.Fall();
            }


            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
