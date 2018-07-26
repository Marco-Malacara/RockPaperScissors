using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    public abstract class Player
    {
        public string name;
        public string choice;
        public int score;

        public Player()
        {
        }

        public abstract void MakeChoice();

        public virtual void GetPlayerName()
        {
            name = "Lerroy Jankins!";
        }
        public virtual void DisplayListOfGesutres()
        {
            List<string> gestures = new List<string>();

            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("Scissors");
            gestures.Add("Lizard");
            gestures.Add("Spock");
            Console.WriteLine(" ");

            foreach (string gesture in gestures)
            {
                Console.WriteLine(gesture);
            }
            
        }
        public virtual void StartGame()
        {
            Console.WriteLine("If you're seeing this; the game broke...sorry...");
        }
    }
}
