using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewPrgrams
{
    internal class SnakeLadder
    {
        public static void SnakeLdderGame()
        {
            int StartPos = 0;
            Console.WriteLine("One person started the game from position 0");
        }

        public static void Game()
        {

            Random Dice = new Random();
            int DiceValue = Dice.Next(1, 7);

            Console.WriteLine("Dice Rolled "+DiceValue);

            int PersonPos = 1;

            if (DiceValue == 6 || DiceValue == 4)
            {
                Console.WriteLine("No movement for user");
            }

            else if (DiceValue == 2 || DiceValue == 5)
            {
               PersonPos = PersonPos - DiceValue; 
               Console.WriteLine("Skake bites");
            }
            else
            { 
               PersonPos = PersonPos + DiceValue;
               Console.WriteLine("Climbed Ladder");
            }

        }

    }
}
