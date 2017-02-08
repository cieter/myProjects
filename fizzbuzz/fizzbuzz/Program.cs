using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FizzBuzz");
            while (true)
            {
                Console.WriteLine("Put in a random number.");
                String UserInput = Console.ReadLine();
                int Input = 0;
                while (true)
                {
                    if (Int32.TryParse(UserInput, out Input))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid character(s), Try Again");
                        UserInput = Console.ReadLine();
                    }
                }
                if (Input % 3 == 0 && Input % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (Input % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (Input % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                if (Input % 3 != 0 && Input % 5 != 0)
                {
                    Console.WriteLine("This number can not be devided by 3 or 5.");
                }
            }





            //  Console.WriteLine("Press enter to exit..."); Dit werkt niet, omdat ik loops heb gemaakt.
            //Console.ReadLine();
        }
    }
}
