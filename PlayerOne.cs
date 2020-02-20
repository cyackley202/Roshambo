using System;
using System.Collections.Generic;
using System.Text;

namespace Memory
{
    public class PlayerOne : Player
    {
        public override Roshambo generateRoshamboValue()
        {
            return Roshambo.Rock;
        }

    }
}
