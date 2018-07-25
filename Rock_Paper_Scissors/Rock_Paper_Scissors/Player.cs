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
        protected string playOneChoice;
        protected string playerTwoThrow;

        //constructor
        public Player()
        {

        }

        //member methods (CAN DO)
        public virtual void GetPlayerName()
        {
            name = "Lerroy Jankins!";
            Console.WriteLine("You're now playing against " + name + ".");
        }
        public void DisplayListOfGesutres()
        {
            List<string> gestures = new List<string>();
            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("Scissors");
            gestures.Add("Lizard");
            gestures.Add("Spock");

            foreach(string gesture in gestures)
            {
                Console.WriteLine(gesture);
            }
        }
        public virtual void PlayerTwoInput()
        {
            Console.WriteLine("Player Two's turn!");
        }
    }
}
