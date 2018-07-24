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

        //member constructor

        //member methods
        public override void GetPlayerName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Welcome " + name + " to the game!");
        }
        public void SetUpTwoPlayerGame()
        {

        }
    }
}
