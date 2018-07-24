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
        Player setUpGame;
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
            Console.WriteLine("Would you like to set up a game against another Player?");
            Console.WriteLine("Input no to setup a game versus an AI.");

            string userChoice = Console.ReadLine();

            if (userChoice.ToLower() == "yes")
            {
                Console.WriteLine("You have set up a game against another person! Good luck and have fun!");
                playerTwo = new Human();
                playerTwo.GetPlayerName();
                setUpGame = new Human();
                setUpGame.DisplayListOfGesutres();
            }
            else if(userChoice.ToLower() == "no")
            {

                playerTwo = new AI();
                playerTwo.GetPlayerName();
            }
            else
            {
                Console.WriteLine("Sorry that input is not valid please try again!");
                SetUpOpponent();
            }
        }
        public void MainMenu()
        {
            Console.WriteLine("Press [1] to see game rules.");
            Console.WriteLine("Press [2] to set up opponent!");

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    rules.DisplayRules();
                    break;
                case "2":
                    SetUpOpponent();
                    break;
            }
            MainMenu();


        }
    }
}
