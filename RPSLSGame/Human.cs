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
        public string FirstPlayerSelectGesture()
        {
            Console.WriteLine($"{playerName} Choose a gesture.");
            
            for (int i = 0; i < gestures.Count; i++)
            {
                Console.WriteLine($"{gestures[i].name}");
            }            

            string userInput = Console.ReadLine();

            List<string> validOptions = new List<string>() { "Rock", "Paper", "Scissor", "Lizard", "Spock" };

            if (validOptions.Contains(userInput))
            {
                playerGesture = userInput;
                return userInput;
            }
            else
            {
                Console.WriteLine("Invalid choice try again");
                return FirstPlayerSelectGesture();
            }
            
        }
        public string SecondPlayerSelectGesture()
        {
            Console.WriteLine($"{playerTwo.playerName} Choose a gesture.");
            
            for (int i = 0; i < gestures.Count; i++)
            {
                Console.WriteLine($"{gestures[i].name}");
            }
            string userInput = Console.ReadLine();

            List<string> validOptions = new List<string>() { "Rock", "Paper", "Scissor", "Lizard", "Spock" };

            if (validOptions.Contains(userInput))
            {
                playerGesture = userInput;
                return userInput;
            }
            else
            {
                Console.WriteLine("Invalid choice try again.");
                return SecondPlayerSelectGesture();
            }
            
        }

        
    }
}
