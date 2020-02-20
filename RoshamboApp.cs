using System;
using System.Collections.Generic;
using System.Text;

namespace Memory
{
    public class RoshamboApp
    {
      public static void SetTermsOfPlay()
        {
            Console.WriteLine("What is your name?");

            string playerName = Console.ReadLine();

            Console.WriteLine($" Hi {playerName}, Who would you like to play against?");

            Console.WriteLine("Player [1] or Player [2]?");

            int opponent = int.Parse(Console.ReadLine());

            PlayerOne playerOne = new PlayerOne();
            PlayerTwo playerTwo = new PlayerTwo();
            PlayerThree playerThree = new PlayerThree();

            var playerOneChoice = playerOne.generateRoshamboValue();
            var playerTwoChoice = playerTwo.generateRoshamboValue();
            var playerThreeChoice = playerThree.generateRoshamboValue();

            if (opponent == 1)
            {
                if (playerOneChoice == Roshambo.Rock && playerThreeChoice == Roshambo.Rock)
                {
                    Console.WriteLine("It's a tie!");
                }
                else if (playerOneChoice == Roshambo.Rock && playerThreeChoice == Roshambo.Paper)
                {
                    Console.WriteLine("You win!");
                }
                else if (playerOneChoice == Roshambo.Rock && playerThreeChoice == Roshambo.Scissors)
                {
                    Console.WriteLine("You lose!");
                }

            }
            else if (opponent == 2)
            {
                if (playerTwoChoice == Roshambo.Rock && playerThreeChoice == Roshambo.Rock)
                {
                    Console.WriteLine("It's a tie!");
                }
                else if (playerTwoChoice == Roshambo.Rock && playerThreeChoice == Roshambo.Paper)
                {
                    Console.WriteLine("You win!");
                }
                else if (playerTwoChoice == Roshambo.Rock && playerThreeChoice == Roshambo.Scissors)
                {
                    Console.WriteLine("You lose!");
                }
                else if (playerTwoChoice == Roshambo.Paper && playerThreeChoice == Roshambo.Rock)
                {
                    Console.WriteLine("You lose!");
                }
                else if (playerTwoChoice == Roshambo.Paper && playerThreeChoice == Roshambo.Paper)
                {
                    Console.WriteLine("It's a tie!");
                }
                else if (playerTwoChoice == Roshambo.Paper && playerThreeChoice == Roshambo.Scissors)
                {
                    Console.WriteLine("You win!");
                }
                else if (playerTwoChoice == Roshambo.Scissors && playerThreeChoice == Roshambo.Rock)
                {
                    Console.WriteLine("You win!");
                }
                else if (playerTwoChoice == Roshambo.Scissors && playerThreeChoice == Roshambo.Paper)
                {
                    Console.WriteLine("You lose!");
                }
                else if (playerTwoChoice == Roshambo.Scissors && playerThreeChoice == Roshambo.Scissors)
                {
                    Console.WriteLine("It's a tie!");
                }

            }

        }

    }
}
