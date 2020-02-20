using System;
using System.Collections.Generic;
using System.Text;

namespace Memory
{
    public abstract class Player
    {
        public string Name { get; set; }
        
        public int RoshamboValue { get; set; }

        public abstract Roshambo generateRoshamboValue();
        

        
    };
}
