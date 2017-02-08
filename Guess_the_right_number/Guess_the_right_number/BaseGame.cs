using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_right_number
{
    class BaseGame
    {
        static public void StartBasicGame()
        {
            Random rnd = new Random();
            int rightNumber = rnd.Next(1, 101);
            int i = 0;
            int min = 1;
            int max = 100;

            Console.WriteLine("Ik denk aan een getal tussen 1 en 100. (1 en 100 beide meegerekend) Raad dit getal!");

            while (true)
            {
                Console.WriteLine("Raad: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out i))
                {
                    Console.WriteLine("Dat is geen getal.");
                }

                else if (i > max)
                {
                    Console.WriteLine("Het getal dat u heeft ingevoerd is te hoog.");
                }

                else if (i < min)
                {
                    Console.WriteLine("Het getal dat u heeft ingevoerd is te laag.");
                }

                else if (i < rightNumber)
                {
                    Console.WriteLine("Het getal dat ik zoek is hoger dan {0}.", i);
                }

                else if (i > rightNumber)
                {
                    Console.WriteLine("Het getal dat ik zoek is lager dan {0}.", i);
                }

                else if (i == rightNumber)
                {
                    Console.WriteLine("Gefeliciteerd, het getal is inderdaad {0}.", i);
                    return;
                }
            }
        }
    }
}
