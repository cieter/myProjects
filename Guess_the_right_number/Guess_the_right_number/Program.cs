using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_right_number
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welkom!");
            Console.WriteLine("Probeer het juiste getal te raden.");
            Console.WriteLine("Als je niet het juiste getal hebt geraden, krijg je te zien of je hoger of lager moet raden.");
            Console.WriteLine("Veel succes!");
            BaseGame.StartBasicGame();
            StartOver.Replay();
        }
    }   
}
