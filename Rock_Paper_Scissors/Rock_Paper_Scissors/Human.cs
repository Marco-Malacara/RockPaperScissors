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

        public override void MakeChoice()
        {
            Console.WriteLine(" ");
            DisplayListOfGesutres();
            Console.WriteLine("What would you like to throw?----->");
            Console.WriteLine(" ");
            choice = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine(choice);
        }
    }
}
