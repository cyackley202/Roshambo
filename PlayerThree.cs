using System;
using System.Collections.Generic;
using System.Text;

namespace Memory
{
    class PlayerThree : Player
    {
        public override Roshambo generateRoshamboValue()
        {
            bool userOption = false;
            string whatToThrow = "booty";
           
            while (userOption == false)
            {
                Console.WriteLine("Would you like to throw Rock, Paper, or Scissors?");

                whatToThrow = Console.ReadLine();
                userOption = Validator.IsPlayerThreeValid(whatToThrow);
                if (!userOption)
                {
                    Console.WriteLine("That is not a valid input. Please enter a valid input.");
                }
              
            }

            

                if (Enum.TryParse<Roshambo>(whatToThrow, out var userInput))
                {
                    switch (userInput)
                    {
                        case Roshambo.Rock:
                            
                            return Roshambo.Rock;

                        case Roshambo.Paper:
                            
                            return Roshambo.Paper;

                        case Roshambo.Scissors:
                            
                            return Roshambo.Scissors;

                        default:
                            break;
                    }
                }
              

                
            
                return userInput;
            

               
                
              
                    
               
            
            // Put this shit in a while loop
        }
    } 
}
