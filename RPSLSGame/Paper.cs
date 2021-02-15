using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSGame
{
    class Paper : Gesture
    {
        //member variables

        //constructor
        public Paper()
        {
            name = "Paper";
            string rock = "Rock";
            string spock = "Spock";
            List<string> beats = new List<string>();

            beats.Add(rock);
            beats.Add(spock);
        }

        //member methods
    }
}
