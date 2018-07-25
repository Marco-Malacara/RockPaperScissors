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
        public string playerOneWon;
        public int playerOneScore;
        public int playerTwoScore;
        //member constructor
        public Human()
        {
            playerOneChoice = null;
            playerTwoChoice = null;
            playerOneWon = null;
            int playerOneScore = 0;
            int playerTwoScore = 0;
        }

        //member methods
        public override void GetPlayerName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Welcome " + name + " to the game!");
        }
        public override void StartGame()
        {
            DisplayListOfGesutres();
            Console.WriteLine("Player One picks first!");
            Console.WriteLine("What would you like to throw?----->");

            string playerOneChoice = Console.ReadLine();

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
        public void GetWinner()
        {
            while(playerOneScore < 2 || playerTwoScore <2)
            {
                
                if (playerOneWon == "won")
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Congratulations Player One!");
                    playerOneScore = playerOneScore + 1;
                    Console.WriteLine("The score is now Player One = " + playerOneScore + " Player Two = " + playerTwoScore + ".");
                    Console.WriteLine(" ");
                    StartGame();
                }
                else if(playerOneWon == "no")
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Congratulations Player Two!");
                    playerTwoScore = playerTwoScore + 1;
                    Console.WriteLine("The score is now Player One = " + playerOneScore + " Player Two = " + playerTwoScore + ".");
                    Console.WriteLine(" ");
                    StartGame();
                }
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("You both drew the same thing! this round is a draw!");
                    playerTwoScore = playerTwoScore + 1;
                    playerOneScore = playerOneScore + 1;
                    Console.WriteLine("The score is now Player One = " + playerOneScore + " Player Two = " + playerTwoScore + ".");
                    Console.WriteLine(" ");
                    StartGame();

                }
            }
        }
    }
}
