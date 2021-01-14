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

        //constructor
        public Game()
        {
            playerOne = new Player();
            playerTwo = new Player();
        }
        //member methods

        public void DisplayRules()
        {
            Console.WriteLine("Select solo or Co-op then select your gestures\n" + "player with most rounds won wins the game.");
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
