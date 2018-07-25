using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Human : Player
    {
        //member variables
        public string playerOneChoice;
        public string playerTwoChoice;
        //member constructor
        public Human()
        {
            playerOneChoice = "No gesture chosen";
            playerTwoChoice = null;
        }

        //member methods
        public override void GetPlayerName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Welcome " + name + " to the game!");
        }
        public void PlayerVsPlayerGame()
        {
            DisplayListOfGesutres();
            Console.WriteLine("Player One picks first!");
            Console.Write("What would you like to throw?--->");

            string playerOneChoice = Console.ReadLine();

            DisplayListOfGesutres();
            Console.WriteLine("Player Two's turn");
            Console.WriteLine("What would you like to throw?----->");

            string playerTwoChoice = Console.ReadLine();
            
            if(playerOneChoice.ToLower() == "rock" && playerTwoChoice.ToLower() == "scissors" || playerTwoChoice.ToLower() == "lizard")
            {
                Console.Write("ROCK! beats " + playerTwoChoice.ToUpper() + "! Player One Wins!");
            }
            else if (playerOneChoice.ToLower() == "scissors" && playerTwoChoice.ToLower() == "paper" || playerTwoChoice.ToLower() == "lizard")
            {
                Console.Write("SCISSORS! beats " + playerTwoChoice.ToUpper() + "! Player One Wins!");
            }
            else if (playerOneChoice.ToLower() == "paper" && playerTwoChoice.ToLower() == "rock" || playerTwoChoice.ToLower() == "spock")
            {
                Console.Write("PAPER! beats " + playerTwoChoice.ToUpper() + "! Player One Wins!");
            }
            else if (playerOneChoice.ToLower() == "lizard" && playerTwoChoice.ToLower() == "paper" || playerTwoChoice.ToLower() == "spock")
            {
                Console.Write("LIZARD! beats " + playerTwoChoice.ToUpper() + "! Player One Wins!");
            }
            else if (playerOneChoice.ToLower() == "spock" && playerTwoChoice.ToLower() == "rock" || playerTwoChoice.ToLower() == "scissors")
            {
                Console.Write("PAPER beats " + playerTwoChoice.ToUpper() + "! Player One Wins!");
            }
            else if (playerOneChoice == playerTwoChoice)
            {
              Console.WriteLine("You both threw " + playerOneChoice.ToUpper() + "! This round is a draw!");
            }
            else
            {
                Console.WriteLine("The given input is invalid please try again!");
                PlayerVsPlayerGame();
            }
        }
    }
}
