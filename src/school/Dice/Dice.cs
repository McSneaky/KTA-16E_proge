using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Dice
    {
        private int sides { get; }
        private static readonly Random random = new Random();

        public Dice(int sides)
        {
            this.sides = sides;
        }

        // Cool shorthand, but dice with sides 1 to n will need n lines of code in here
        public static Dice D6 => new Dice(6);
        public static Dice D8 => new Dice(8);

        public int Roll()
        {
            return random.Next(1, this.sides + 1);
        }
    }
}
