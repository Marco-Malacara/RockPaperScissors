using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    public abstract class Player
    {
        //member variables (HAS A)
        protected string name;
        public string choice;
        //public string playerOneChoice;
        //public string playerTwoChoice;
        public string playerOneWon;
        public int playerOneScore;
        public int playerTwoScore;

        //constructor
        public Player()
        {
            //playerOneChoice = null;
            //playerTwoChoice = null;
            playerOneWon = null;
            playerOneScore = 0;
            playerTwoScore = 0;
        }

        public abstract void MakeChoice();

        //member methods (CAN DO)
        public virtual void GetPlayerName()
        {
            name = "Lerroy Jankins!";
            Console.WriteLine("You're now playing against " + name + ".");
        }
        public virtual void DisplayListOfGesutres()
        {
            List<string> gestures = new List<string>();
            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("Scissors");
            gestures.Add("Lizard");
            gestures.Add("Spock");

            foreach (string gesture in gestures)
            {
                Console.WriteLine(gesture);
            }
            
        }
        public virtual void StartGame()
        {
            Console.WriteLine("If you're seeing this; the game broke...sorry...");
        }
        public void GetWinner()
        {
            while (playerOneScore < 2 && playerTwoScore < 2)
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
                else if (playerOneWon == "no")
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
            if(playerOneScore > playerTwoScore)
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
