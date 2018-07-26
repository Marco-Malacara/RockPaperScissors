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
            Console.WriteLine(playerOne.name);
            playerOne.MakeChoice();
            Console.WriteLine(playerTwo.name);
            playerTwo.MakeChoice();
            RoundWinner();
        }

        public void SelectGameType()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Press [1] to play SINGLE PLAYER!");
            Console.WriteLine("Press [2] to play MULTIPLAYER!");
            Console.WriteLine(" ");

            string userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                Console.WriteLine(" ");
                Console.WriteLine("You have selected single player!");
                Console.WriteLine("Press [1] to start game!");
                Console.WriteLine("OR");
                Console.WriteLine("Press [2] to retrun to Main Menu.");
                Console.WriteLine(" ");
                string userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    playerTwo = new AI();
                    playerOne.GetPlayerName();
                    playerTwo.GetPlayerName();
                    Console.WriteLine(playerOne.name + " is now playing against " + playerTwo.name + ".");
                    RunRound();
                }
                else if (userInput == "2")
                {
                    MainMenu();
                }
                else
                {
                    Console.WriteLine("Not a valid selection! Please try again!");
                    SelectGameType();
                }

                playerTwo = new Human();
                playerOne.GetPlayerName();
                playerTwo.GetPlayerName();
                RunRound();
                
            }
            else if(userChoice == "2")
            {
                Console.WriteLine(" ");
                Console.WriteLine("You have selected MULTIPLAYER!");
                Console.WriteLine("Press [1] to start game!");
                Console.WriteLine("OR");
                Console.WriteLine("Press [2] to retrun to Main Menu.");
                Console.WriteLine(" ");
                string userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    playerTwo = new Human();
                    playerOne.GetPlayerName();
                    playerTwo.GetPlayerName();
                    RunRound();
                }
                else if (userInput == "2")
                {
                    MainMenu();
                }
                else
                {
                    Console.WriteLine("Not a valid selection! Please try again!");
                    SelectGameType();
                }
            }
            else
            {
                Console.WriteLine("Sorry that input is not valid please try again!");
                SelectGameType();
            }
        }
        public void MainMenu()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Press [1] to choose game!");
            Console.WriteLine("Press [2] to see rules!");
            Console.WriteLine(" ");

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    SelectGameType();
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
                    Console.WriteLine("The score is now " + playerOne.name + " = " + playerOne.score + " " + playerTwo.name + " = " + playerTwo.score + ".");
                    Console.WriteLine(" ");
                    RunRound();
                }
                else if (playerOneWon == "no")
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Congratulations Player Two!");
                    playerTwo.score = playerTwo.score + 1;
                    Console.WriteLine("The score is now " + playerOne.name + " = " + playerOne.score + " " + playerTwo.name + " = " + playerTwo.score + ".");
                    Console.WriteLine(" ");
                    RunRound();
                }
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("You both drew the same thing! this round is a draw!");
                    Console.WriteLine("The score is still " + playerOne.name + " = " + playerOne.score + " " + playerTwo.name + " = " + playerTwo.score + ".");
                    Console.WriteLine(" ");
                    RunRound();

                }
            }
            if (playerOne.score > playerTwo.score)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Congratulations " + playerOne.name + " You are the Winner! Thanks for Playing!");
                Console.WriteLine(" ");
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("Congratulations " + playerTwo.name + " You are the Winner! Thanks for Playing!");
                Console.WriteLine(" ");
            }
        }
    }
}
