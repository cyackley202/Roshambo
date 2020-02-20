using System;
using System.Collections.Generic;
using System.Text;

namespace Memory
{
    public static class Validator
    {
        public static bool IsPlayerThreeValid(string userInput) 
        {
            if (userInput.Equals("rock", StringComparison.OrdinalIgnoreCase) || userInput.Equals("paper", StringComparison.OrdinalIgnoreCase) || userInput.Equals("scissors", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
