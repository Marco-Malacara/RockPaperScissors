using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Human : Player
    {
        public Human()
        {
            playerOneChoice = null;
            playerTwoChoice = null;
            playerOneWon = null;
        }

     
        public override void StartGame()
        {
            Console.WriteLine(" ");
            DisplayListOfGesutres();
            Console.WriteLine("Player One picks first!");
            Console.WriteLine("What would you like to throw?----->");
            Console.WriteLine(" ");

            string playerOneChoice = Console.ReadLine();
            Console.WriteLine(" ");

            DisplayListOfGesutres();
            Console.WriteLine("Player Two's turn");
            Console.WriteLine("What would you like to throw?----->");

            string playerTwoChoice = Console.ReadLine();

            if (playerOneChoice.ToLower() == "rock" && playerTwoChoice.ToLower() == "scissors" || playerTwoChoice.ToLower() == "lizard")
            {
                Console.WriteLine(" ");
                Console.WriteLine("ROCK! beats " + playerTwoChoice.ToUpper() + "!");
                Console.WriteLine(" ");
                playerOneWon = "won";
                GetWinner();
            }
            else if (playerOneChoice.ToLower() == "scissors" && playerTwoChoice.ToLower() == "paper" || playerTwoChoice.ToLower() == "lizard")
            {
                Console.WriteLine(" ");
                Console.WriteLine("SCISSORS! beats " + playerTwoChoice.ToUpper() + "!");
                Console.WriteLine(" ");
                playerOneWon = "won";
                GetWinner();
            }
            else if (playerOneChoice.ToLower() == "paper" && playerTwoChoice.ToLower() == "rock" || playerTwoChoice.ToLower() == "spock")
            {
                Console.WriteLine(" ");
                Console.WriteLine("PAPER! beats " + playerTwoChoice.ToUpper() + "!");
                Console.WriteLine(" ");
                playerOneWon = "won";
                GetWinner();
            }
            else if (playerOneChoice.ToLower() == "lizard" && playerTwoChoice.ToLower() == "paper" || playerTwoChoice.ToLower() == "spock")
            {
                Console.WriteLine(" ");
                Console.WriteLine("LIZARD! beats " + playerTwoChoice.ToUpper() + "!");
                Console.WriteLine(" ");
                playerOneWon = "won";
                GetWinner();
            }
            else if (playerOneChoice.ToLower() == "spock" && playerTwoChoice.ToLower() == "rock" || playerTwoChoice.ToLower() == "scissors")
            {
                Console.WriteLine(" ");
                Console.WriteLine("PAPER beats " + playerTwoChoice.ToUpper() + "!");
                Console.WriteLine(" ");
                playerOneWon = "won";
                GetWinner();
            }
            else if (playerOneChoice == playerTwoChoice)
            {
                Console.WriteLine(" ");
                Console.WriteLine("You both threw " + playerOneChoice.ToUpper() + "! This round is a draw!");
                Console.WriteLine(" ");
                playerOneWon = "";
                GetWinner();
            }
            else if (playerTwoChoice.ToLower() == "rock" && playerOneChoice.ToLower() == "scissors" || playerOneChoice.ToLower() == "lizard")
            {
                Console.WriteLine(" ");
                Console.WriteLine("ROCK! beats " + playerOneChoice.ToUpper() + "!");
                Console.WriteLine(" ");
                playerOneWon = "no";
                GetWinner();
            }
            else if (playerTwoChoice.ToLower() == "scissors" && playerOneChoice.ToLower() == "paper" || playerOneChoice.ToLower() == "lizard")
            {
                Console.WriteLine(" ");
                Console.WriteLine("SCISSORS! beats " + playerOneChoice.ToUpper() + "!");
                Console.WriteLine(" ");
                playerOneWon = "no";
            }
            else if (playerTwoChoice.ToLower() == "paper" && playerOneChoice.ToLower() == "rock" || playerOneChoice.ToLower() == "spock")
            {
                Console.WriteLine(" ");
                Console.WriteLine("PAPER! beats " + playerOneChoice.ToUpper() + "!");
                Console.WriteLine(" ");
                playerOneWon = "no";
            }
            else if (playerTwoChoice.ToLower() == "lizard" && playerTwoChoice.ToLower() == "paper" || playerOneChoice.ToLower() == "spock")
            {
                Console.WriteLine(" ");
                Console.WriteLine("LIZARD! beats " + playerTwoChoice.ToUpper() + "!");
                Console.WriteLine(" ");
                playerOneWon = "no";
            }
            else if (playerTwoChoice.ToLower() == "spock" && playerTwoChoice.ToLower() == "rock" || playerTwoChoice.ToLower() == "scissors")
            {
                Console.WriteLine(" ");
                Console.WriteLine("PAPER beats " + playerTwoChoice.ToUpper() + "!");
                Console.WriteLine(" ");
                playerOneWon = "no";
            }
            else if (playerOneChoice == playerTwoChoice)
            {
                Console.WriteLine(" ");
                Console.WriteLine("You both threw " + playerOneChoice.ToUpper() + "! This round is a draw!");
                Console.WriteLine(" ");
                playerOneWon = "draw";
            }
            else
            {
                Console.WriteLine("The given input is invalid please try again!");
                StartGame();
            }
        }
    }
}
