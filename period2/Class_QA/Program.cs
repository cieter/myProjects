using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_QA
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("please enter a name");
            string playerName = Console.ReadLine();
            Console.WriteLine("Your hero is now called: " + playerName);
            Hero player = new Hero(playerName);
            player.GetName();
           

            player.ShowInventory();
            player.ShowArmor();

            Console.WriteLine("please enter a boss name");
            string bossName = Console.ReadLine();
            Boss boss = new Boss(bossName);
            boss.Fly();
            boss.ShowArmor();
            boss.ShowInventory();

            boss.Kill();

            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
