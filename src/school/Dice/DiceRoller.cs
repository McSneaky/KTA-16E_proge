using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class DiceRoller
    {
        public static int roll(string userInput)
        {
            int diceCount = getDiceCount(clearInput(userInput));
            int diceSides = getDiceSides(clearInput(userInput));

            int rollSum = 0;
            for (int i = 0; i < diceCount; i++)
            {
                Dice dice = new Dice(diceSides);
                rollSum += dice.Roll();
            }
            return rollSum;
        }

        /// <summary>
        ///     
        /// </summary>
        /// <param name="input">
        ///     Cleared user input like 3d5, 10d10, 444d333 etc
        /// </param>
        /// <returns>
        ///     Count of dices to roll / or rolls to make
        /// </returns>
        public static int getDiceCount(string input)
        {
            return int.Parse(input.Split('d')[0]);
        }

        public static int getDiceSides(string input)
        {
            return int.Parse(input.Split('d')[1]);
        }

        private static string clearInput(string userInput)
        {
            return userInput.Split(' ')[1];
        }
    }
}
