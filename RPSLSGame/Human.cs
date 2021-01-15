using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSGame
{
    class Human : Player
    {
        //member variables
        Player playerTwo;

        //constructor
        public Human()
        {
            playerName = "Player One";
            playerTwo = new Player();
            playerTwo.playerName = "Player Two";
        }

        //member methods
        public int SelectGesture()
        {
            Console.WriteLine($"{playerName} Choose a gesture. {playerTwo.playerName} Choose a gesture.");
            //May not do what I want it to ^^
            for (int i = 0; i < gestures.Count; i++)
            {
                Console.WriteLine($"Press {i} for {gestures[i]}");
            }
            string userInput = Console.ReadLine();
            int yourGesture = Int32.Parse(userInput);
            return yourGesture;

        }


    }
}
