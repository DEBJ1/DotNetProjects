using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_conditionals_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("What's your name?");
            string inputName = Console.ReadLine().ToLower();

            //2
            switch (inputName)
            {
                //3
                case "fred": // Same as checking: if (inputName == "fred")
                    Console.WriteLine("Hey Fred, let's go golfing.");
                    //4
                    break;
                case "karl": // Same as checking: else if (inputName == "karl")
                    Console.WriteLine("Let's hang.");
                    break;
                case "john": // Same as checking: else if (inputName == "john")
                    Console.WriteLine("Sorry, I'm busy right now.");
                    break;
                default: // Same as: else
                    Console.WriteLine("Hey " + inputName + ", can I call you back in a minute?");
                    break; // This break is required
            }

            //5
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("What's your friend's name?");
                string friend = Console.ReadLine().ToLower();

                switch (friend)
                {
                    case "jay":
                        Console.WriteLine("Jay is a great guy.");
                        break;
                    case "paul":
                        Console.WriteLine("Paul is pretty cool.");
                        break;
                    case "kenn":
                        Console.WriteLine("Kenn has an old soul.");
                        break;
                    case "carr":
                        Console.WriteLine("Carr is the coolest dude ever");
                        break;
                    default:
                        Console.WriteLine($"I don't know {friend}.");
                        break;
                }
            }
        }
    }
}
