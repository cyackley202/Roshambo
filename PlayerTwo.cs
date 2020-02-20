using System;
using System.Collections.Generic;
using System.Text;

namespace Memory
{
    public class PlayerTwo : Player
    {
        public override Roshambo generateRoshamboValue()
        {
            Random rando = new Random();
            int selection = rando.Next(1, 4);

            if (selection == 1)
            {
                return Roshambo.Rock;
            }
            else if (selection == 2)
            {
                return Roshambo.Paper;
            }
            else
            {
                return Roshambo.Scissors;
            }

            
        }
    }
}
