using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class AI : Player
    {
        public override void MakeChoice()
        {
            Random rnd = new Random();
            int AiChoice = rnd.Next(4);
            if (AiChoice == 0)
            {
                choice = "rock";


            }
            else if (AiChoice == 1)
            {
                choice = "scissors";


            }
            else if (AiChoice == 2)
            {
                choice = "paper";

            }
            else if (AiChoice == 3)
            {
                choice = "lizard";

            }
            else if (AiChoice == 4)
            {
                choice = "spock";

            }
        }
        public override void GetPlayerName()
        {
            Console.WriteLine(" ");
            base.GetPlayerName();
        }
    }
}

