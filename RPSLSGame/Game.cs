using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSGame
{
    class Game
    {
        //member variables
        Player playerOne;
        Player playerTwo;
        Player computer;

        //constructor
        public Game()
        {
            playerOne = new Player();
            playerTwo = new Player();
            computer = new Player();
        }
        //member methods

        public void DisplayRules()
        {
            Console.WriteLine("Select solo or Co-op then select your gestures\n" + "player with best two out of three wins.");
        }

        public void SelectPlayers()
        {
            string singlePlayer = "Single Player";
            string multiPlayer = "Co-op";

            Console.WriteLine($"Select {singlePlayer} or {multiPlayer}?");
            string userInput = Console.ReadLine();

            if (userInput == singlePlayer)
            {
                Console.WriteLine("You have chosen Single Player.");
            }
            else
            {
                Console.WriteLine("You have chosen Co-op.");
            }
        }



        //1. Display the rules
        //2. Single Player or Multiplayer?
        //3. Who goes first? Choose a gesture.
        //4. Next person chooses a gesture.
        //5. Make a comparison between the two gestures.
        //6. Whoever has the winning gesture wins the round.
        //7. Repeat until best of three.
        //8. Display who the winner is!
    }
}
