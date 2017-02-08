using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _99_bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the 99 bottles of beer on the wall song");
            for ( int i = 99; i >= 1 ; i--)
            {
                if(i > 2)
                {
                    Console.WriteLine("{0} bottles of beer on the wall. {0} bottles of beer. \n You take one down and pass it around. {1} bottles of beer on the wall", i, i - 1);
                    Thread.Sleep(1000);
                }
                else if(i == 2)
                {
                    Console.WriteLine("{0} bottles of beer on the wall. {0} bottles of beer. \n You take one down and pass it around. {1} bottle of beer on the wall", i, i - 1);
                    Thread.Sleep(1000);
                }
                else if(i == 1)
                {
                    Console.WriteLine("{0} bottle of beer on the wall. {0} bottle of beer. \n You take one down and pass it around. no more bottles of beer on the wall", i);
                    Console.WriteLine("Go to the store and buy some more. 99 bottles of beer on the wall.");
                }
                
            }
            Console.WriteLine("press enter to exit...");
            Console.ReadLine();
        }
    }
}

