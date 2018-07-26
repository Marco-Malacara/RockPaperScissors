using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class AI : Player
    {
        //member vairables

        //member constructor

        //member methods
        public override void MakeChoice()
        {
            // define how computer player makes choice
        }
        public override void GetPlayerName()
        {
            base.GetPlayerName();
        }
        //public override void StartGame()
        //{
        //    DisplayListOfGesutres();
        //    Console.WriteLine("Player One picks first!");
        //    Console.WriteLine("What would you like to throw?----->");
        //    Console.WriteLine(" ");

        //    string playerOneChoice = Console.ReadLine();
        //    Console.WriteLine(" ");

        //    ComputerChoice();

        //    if (playerOneChoice.ToLower() == "rock" && playerTwoChoice.ToLower() == "scissors" || playerTwoChoice.ToLower() == "lizard")
        //    {
        //        Console.WriteLine(" ");
        //        Console.WriteLine("ROCK! beats " + playerTwoChoice.ToUpper() + "!");
        //        Console.WriteLine(" ");
        //        playerOneWon = "won";
        //        GetWinner();
        //    }
        //    else if (playerOneChoice.ToLower() == "scissors" && playerTwoChoice.ToLower() == "paper" || playerTwoChoice.ToLower() == "lizard")
        //    {
        //        Console.WriteLine(" ");
        //        Console.WriteLine("SCISSORS! beats " + playerTwoChoice.ToUpper() + "!");
        //        Console.WriteLine(" ");
        //        playerOneWon = "won";
        //        GetWinner();
        //    }
        //    else if (playerOneChoice.ToLower() == "paper" && playerTwoChoice.ToLower() == "rock" || playerTwoChoice.ToLower() == "spock")
        //    {
        //        Console.WriteLine(" ");
        //        Console.WriteLine("PAPER! beats " + playerTwoChoice.ToUpper() + "!");
        //        Console.WriteLine(" ");
        //        playerOneWon = "won";
        //        GetWinner();
        //    }
        //    else if (playerOneChoice.ToLower() == "lizard" && playerTwoChoice.ToLower() == "paper" || playerTwoChoice.ToLower() == "spock")
        //    {
        //        Console.WriteLine(" ");
        //        Console.WriteLine("LIZARD! beats " + playerTwoChoice.ToUpper() + "!");
        //        Console.WriteLine(" ");
        //        playerOneWon = "won";
        //        GetWinner();
        //    }
        //    else if (playerOneChoice.ToLower() == "spock" && playerTwoChoice.ToLower() == "rock" || playerTwoChoice.ToLower() == "scissors")
        //    {
        //        Console.WriteLine(" ");
        //        Console.WriteLine("SPOCK beats " + playerTwoChoice.ToUpper() + "!");
        //        Console.WriteLine(" ");
        //        playerOneWon = "won";
        //        GetWinner();
        //    }
        //    else if (playerOneChoice == playerTwoChoice)
        //    {
        //        Console.WriteLine(" ");
        //        Console.WriteLine("You both threw " + playerOneChoice.ToUpper() + "! This round is a draw!");
        //        Console.WriteLine(" ");
        //        playerOneWon = "";
        //        GetWinner();
        //    }
        //    else if (playerTwoChoice.ToLower() == "rock" && playerOneChoice.ToLower() == "scissors" || playerOneChoice.ToLower() == "lizard")
        //    {
        //        Console.WriteLine(" ");
        //        Console.WriteLine("ROCK! beats " + playerOneChoice.ToUpper() + "!");
        //        Console.WriteLine(" ");
        //        playerOneWon = "no";
        //        GetWinner();
        //    }
        //    else if (playerTwoChoice.ToLower() == "scissors" && playerOneChoice.ToLower() == "paper" || playerOneChoice.ToLower() == "lizard")
        //    {
        //        Console.WriteLine(" ");
        //        Console.WriteLine("SCISSORS! beats " + playerOneChoice.ToUpper() + "!");
        //        Console.WriteLine(" ");
        //        playerOneWon = "no";
        //        GetWinner();
        //    }
        //    else if (playerTwoChoice.ToLower() == "paper" && playerOneChoice.ToLower() == "rock" || playerOneChoice.ToLower() == "spock")
        //    {
        //        Console.WriteLine(" ");
        //        Console.WriteLine("PAPER! beats " + playerOneChoice.ToUpper() + "!");
        //        Console.WriteLine(" ");
        //        playerOneWon = "no";
        //        GetWinner();
        //    }
        //    else if (playerTwoChoice.ToLower() == "lizard" && playerTwoChoice.ToLower() == "paper" || playerOneChoice.ToLower() == "spock")
        //    {
        //        Console.WriteLine(" ");
        //        Console.WriteLine("LIZARD! beats " + playerTwoChoice.ToUpper() + "!");
        //        Console.WriteLine(" ");
        //        playerOneWon = "no";
        //        GetWinner();
        //    }
        //    else if (playerTwoChoice.ToLower() == "spock" && playerTwoChoice.ToLower() == "rock" || playerTwoChoice.ToLower() == "scissors")
        //    {
        //        Console.WriteLine(" ");
        //        Console.WriteLine("SPOCK beats " + playerTwoChoice.ToUpper() + "!");
        //        Console.WriteLine(" ");
        //        playerOneWon = "no";
        //        GetWinner();
        //    }
        //    else if (playerOneChoice == playerTwoChoice)
        //    {
        //        Console.WriteLine(" ");
        //        Console.WriteLine("You both threw " + playerOneChoice.ToUpper() + "! This round is a draw!");
        //        Console.WriteLine(" ");
        //        playerOneWon = "draw";
        //        GetWinner();
        //    }
        //    else
        //    {
        //        Console.WriteLine("The given input is invalid please try again!");
        //        StartGame();
        //    }
        //}
        //public void ComputerChoice()
        //{
        //    Random rnd = new Random();
        //    int AiChoice = rnd.Next(4);
        //    if (AiChoice == 0)
        //    {
        //        playerTwoChoice = "rock";
                
                
        //    }
        //    else if (AiChoice == 1)
        //    {
        //        playerTwoChoice = "scissors";
                
                
        //    }
        //    else if (AiChoice == 2)
        //    {
        //        playerTwoChoice = "paper";
                
        //    }
        //    else if (AiChoice == 3)
        //    {
        //        playerTwoChoice = "lizard";
                
        //    }
        //    else if (AiChoice == 4)
        //    {
        //        playerTwoChoice = "spock";
                
        //    }

        }
    }
    //public void RandomComputerChoice()
    //{
    //    Random rnd = new Random();
    //    int AiChoice = rnd.Next(6);
    //    if (AiChoice == 0)
    //    {
    //        playerTwoChoice = "rock";
    //        GetWinner();
    //    }
    //    else if (AiChoice == 1)
    //    {
    //        playerTwoChoice = "scissors";
    //        GetWinner();
    //    }
    //    else if (AiChoice == 2)
    //    {
    //        playerTwoChoice = "paper";
    //        GetWinner();
    //    }
    //    else if (AiChoice == 3)
    //    {
    //        playerTwoChoice = "lizard";
    //        GetWinner();
    //    }
    //    else if (AiChoice == 4)
    //    {
    //        playerTwoChoice = "spock";
    //        GetWinner();
    //    }

    //}

