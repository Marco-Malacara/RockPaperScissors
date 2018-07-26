using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Game
    {
        //member variables
        Player playerOne;
        Player playerTwo;
        // Player setUpGame;
        Rule rules;


        //constructor 
        public Game()
        {
            playerOne = new Human();
            rules = new Rule();
        }

        //member methods
        public void SetUpOpponent()
        {
            Console.WriteLine("Press [1] to play against another Human.");
            Console.WriteLine("Press [2] to play against an AI.");

            string userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                Console.WriteLine("You have set up a game against another person! Good luck and have fun!");
                playerTwo = new Human();
                playerOne.StartGame(); ;
                
            }
            else if(userChoice.ToLower() == "2")
            {

                playerTwo = new AI();
                playerTwo.GetPlayerName();
                playerTwo.StartGame();
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
    }
}
