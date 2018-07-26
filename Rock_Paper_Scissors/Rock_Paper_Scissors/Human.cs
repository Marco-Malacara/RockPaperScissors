using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Human : Player
    {
        public Human()
        {
         
        }

        public override void GetPlayerName()
        {
            Console.WriteLine("Please Enter Name:");
            name = Console.ReadLine();
            Console.WriteLine(" ");
        }
        public override void MakeChoice()
        {
            Console.WriteLine("What would you like to throw?----->");
            DisplayListOfGesutres();
            Console.WriteLine(" ");
            choice = Console.ReadLine();
            Console.WriteLine(" ");
        }
    }
}
