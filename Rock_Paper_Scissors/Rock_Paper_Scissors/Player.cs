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
            gestures.Add("Throw Rock!");
            gestures.Add("Throw Paper!");
            gestures.Add("Throw Scissors!");
            gestures.Add("Throw Lizard!");
            gestures.Add("Throw Spock!");

            foreach(string gesture in gestures)
            {
                Console.WriteLine(gesture);
            }
        }
    }
}
