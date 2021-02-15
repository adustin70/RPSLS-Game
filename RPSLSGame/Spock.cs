using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSGame
{
    class Spock : Gesture
    {
        //member variables

        //constructor
        public Spock()
        {
            name = "Spock";
            string scissor = "Scissor";
            string rock = "Rock";
            List<string> beats = new List<string>();

            beats.Add(scissor);
            beats.Add(rock);
        }

        //member methods
    }
}
