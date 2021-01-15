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
    }
}
