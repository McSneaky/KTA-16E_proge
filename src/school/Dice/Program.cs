using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dice dice = new Dice(6, "I'd like to remove it");

            Console.WriteLine("Enter dice to roll, nd6 OR nd8, where n is number of dices");
            string input = Console.In.ReadLine();
            Console.WriteLine($"Rolled: {DiceRoller.roll(input)}");
            pause();
        }

        static void pause()
        {
            Console.Out.WriteLine("Press any key..");
            Console.ReadKey();
        }
    }
}
