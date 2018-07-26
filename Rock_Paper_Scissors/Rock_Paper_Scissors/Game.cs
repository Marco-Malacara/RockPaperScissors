using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Game
    {
        Player playerOne;
        Player playerTwo;
        public string playerOneWon;
        Rule rules;

        public Game()
        {
            playerOne = new Human();
            rules = new Rule();
            playerOneWon = null;
        }

        public void RunRound()
        {
            playerOne.MakeChoice();
            playerTwo.MakeChoice();
            RoundWinner();
        }

        public void SetUpOpponent()
        {
            Console.WriteLine("Press [1] to play against another Human.");
            Console.WriteLine("Press [2] to play against an AI.");

            string userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                Console.WriteLine("You have set up a game against another person! Good luck and have fun!");
                playerTwo = new Human();
                playerOne.GetPlayerName();
                playerTwo.GetPlayerName();
                RunRound();
                
            }
            else if(userChoice.ToLower() == "2")
            {

                playerTwo = new AI();
                playerTwo.GetPlayerName();
                RunRound();
            }
            else
            {
                Console.WriteLine("Sorry that input is not valid please try again!");
                SetUpOpponent();
            }
        }
        public void MainMenu()
        {
            Console.WriteLine("Press [1] to choose game!");
            Console.WriteLine("Press [2] to see rules!");

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    SetUpOpponent();
                    break;
                case "2":
                    rules.DisplayRules();
                    break;
            }
            MainMenu();


        }
        public void RoundWinner()
        {
            if (playerOne.choice.ToLower() == "rock" && playerTwo.choice.ToLower() == "scissors" || playerTwo.choice.ToLower() == "lizard")
            {
                Console.WriteLine(" ");
                Console.WriteLine("ROCK! beats " + playerTwo.choice.ToUpper() + "!");
                Console.WriteLine(" ");
                playerOneWon = "won";
            }
            else if (playerOne.choice.ToLower() == "scissors" && playerTwo.choice.ToLower() == "paper" || playerTwo.choice.ToLower() == "lizard")
            {
                Console.WriteLine(" ");
                Console.WriteLine("SCISSORS! beats " + playerTwo.choice.ToUpper() + "!");
                Console.WriteLine(" ");
                playerOneWon = "won";
            }
            else if (playerOne.choice.ToLower() == "paper" && playerTwo.choice.ToLower() == "rock" || playerTwo.choice.ToLower() == "spock")
            {
                Console.WriteLine(" ");
                Console.WriteLine("PAPER! beats " + playerTwo.choice.ToUpper() + "!");
                Console.WriteLine(" ");
                playerOneWon = "won";
            }
            else if (playerOne.choice.ToLower() == "lizard" && playerTwo.choice.ToLower() == "paper" || playerTwo.choice.ToLower() == "spock")
            {
                Console.WriteLine(" ");
                Console.WriteLine("LIZARD! beats " + playerTwo.choice.ToUpper() + "!");
                Console.WriteLine(" ");
                playerOneWon = "won";
            }
            else if (playerOne.choice.ToLower() == "spock" && playerTwo.choice.ToLower() == "rock" || playerTwo.choice.ToLower() == "scissors")
            {
                Console.WriteLine(" ");
                Console.WriteLine("SPOCK beats " + playerTwo.choice.ToUpper() + "!");
                Console.WriteLine(" ");
                playerOneWon = "won";
            }
            else if (playerOne.choice == playerTwo.choice)
            {
                Console.WriteLine(" ");
                Console.WriteLine("You both threw " + playerOne.choice.ToUpper() + "! This round is a draw!");
                Console.WriteLine(" ");
                playerOneWon = "";
            }
            else if (playerTwo.choice.ToLower() == "rock" && playerOne.choice.ToLower() == "scissors" || playerOne.choice.ToLower() == "lizard")
            {
                Console.WriteLine(" ");
                Console.WriteLine("ROCK! beats " + playerOne.choice.ToUpper() + "!");
                Console.WriteLine(" ");
                playerOneWon = "no";
            }
            else if (playerTwo.choice.ToLower() == "scissors" && playerOne.choice.ToLower() == "paper" || playerOne.choice.ToLower() == "lizard")
            {
                Console.WriteLine(" ");
                Console.WriteLine("SCISSORS! beats " + playerOne.choice.ToUpper() + "!");
                Console.WriteLine(" ");
                playerOneWon = "no";
            }
            else if (playerTwo.choice.ToLower() == "paper" && playerOne.choice.ToLower() == "rock" || playerOne.choice.ToLower() == "spock")
            {
                Console.WriteLine(" ");
                Console.WriteLine("PAPER! beats " + playerOne.choice.ToUpper() + "!");
                Console.WriteLine(" ");
                playerOneWon = "no";
            }
            else if (playerTwo.choice.ToLower() == "lizard" && playerTwo.choice.ToLower() == "paper" || playerOne.choice.ToLower() == "spock")
            {
                Console.WriteLine(" ");
                Console.WriteLine("LIZARD! beats " + playerTwo.choice.ToUpper() + "!");
                Console.WriteLine(" ");
                playerOneWon = "no";
            }
            else if (playerTwo.choice.ToLower() == "spock" && playerTwo.choice.ToLower() == "rock" || playerTwo.choice.ToLower() == "scissors")
            {
                Console.WriteLine(" ");
                Console.WriteLine("SPOCK beats " + playerTwo.choice.ToUpper() + "!");
                Console.WriteLine(" ");
                playerOneWon = "no";
            }
            else
            {
                Console.WriteLine("The given input is invalid please try again!");
                RoundWinner();
            }
            ScoreTracker();
        }
        public void ScoreTracker()
        {
            while (playerOne.score < 2 && playerTwo.score < 2)
            {

                if (playerOneWon == "won")
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Congratulations Player One!");
                    playerOne.score = playerOne.score + 1;
                    Console.WriteLine("The score is now Player One = " + playerOne.score + " Player Two = " + playerTwo.score + ".");
                    Console.WriteLine(" ");
                    RunRound();
                }
                else if (playerOneWon == "no")
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Congratulations Player Two!");
                    playerTwo.score = playerTwo.score + 1;
                    Console.WriteLine("The score is now Player One = " + playerOne.score + " Player Two = " + playerTwo.score + ".");
                    Console.WriteLine(" ");
                    RunRound();
                }
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("You both drew the same thing! this round is a draw!");
                    playerTwo.score = playerTwo.score + 1;
                    playerOne.score = playerOne.score + 1;
                    Console.WriteLine("The score is now Player One = " + playerOne.score + " Player Two = " + playerTwo.score + ".");
                    Console.WriteLine(" ");
                    RunRound();

                }
            }
            if (playerOne.score > playerTwo.score)
            {
                Console.WriteLine("Congratulations Player One! You are the Winner! Thanks for Playing!");
            }
            else
            {
                Console.WriteLine("Congratulations Player Two! You are the Winner! Thanks for Playing!");
            }
        }
    }
}
