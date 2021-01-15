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
        public int FirstPlayerSelectGesture()
        {
            Console.WriteLine($"{playerName} Choose a gesture.");
            
            for (int i = 0; i < gestures.Count; i++)
            {
                Console.WriteLine($"Press {i} for {gestures[i].name}");
            }
            string userInput = Console.ReadLine();
            int yourGesture = Int32.Parse(userInput);
            return yourGesture;
        }
        public int SecondPlayerSelectGesture()
        {
            Console.WriteLine($"{playerTwo.playerName} Choose a gesture.");
            
            for (int i = 0; i < gestures.Count; i++)
            {
                Console.WriteLine($"Press {i} for {gestures[i].name}");
            }
            string userInput = Console.ReadLine();
            int yourGesture = Int32.Parse(userInput);
            return yourGesture;
        }

        //Probably should have a way to check if co-op then give both players the ability to choose???
    }
}
