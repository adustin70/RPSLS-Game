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
        public string ComputerSelectGesture()
        {
            int rand = random.Next(gestures.Count);
            Console.WriteLine($"{playerName} choices are:");
            for (int i = 0; i < gestures.Count; i++)
            {
                Console.WriteLine(gestures[i].name);
            }
            Console.WriteLine($"\n{playerName} chooses {gestures[rand].name}.");
            playerGesture = Console.ReadLine();
            return playerGesture;
        }

    }
}
