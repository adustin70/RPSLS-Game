using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSGame
{
    class Computer : Player
    {
        //member variables
        static Random random = new Random();

        //constructor
        public Computer()
        {
            playerName = "Computer";
        }


        //member methods
        public void ComputerSelectGesture()
        {
            int rand = random.Next(gestures.Count);
            for (int i = 0; i < gestures.Count; i++)
            {
                Console.WriteLine($"{playerName} choices are {gestures[i].name}.\n");
            }
            Console.WriteLine($"{playerName} chooses {gestures[rand].name}.");
            
        }

    }
}
