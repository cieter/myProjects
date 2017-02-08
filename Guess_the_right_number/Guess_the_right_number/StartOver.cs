using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_right_number
{
    class StartOver
    {
        static public void Replay()
        {
            Console.WriteLine("Wilt u het spel nog een keer spelen?");
            Console.WriteLine("Voer 'ja' in om het spel opnieuw te splen en voer 'nee' om niet opnieuw te spelen.");
            string key = Console.ReadLine();
            if (key == "ja")
            {
                BaseGame.StartBasicGame();
                Replay();
            }
            else if (key == "nee")
            {
                ShowGoodBye.SayGoodBye();
            }
            else
            {
                Console.WriteLine("uw invoer was ongeldig.");
                Replay();
            }
        }
    }
}
