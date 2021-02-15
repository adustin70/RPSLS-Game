using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSGame
{
    class Lizard : Gesture
    {
        //member variables

        //constructor
        public Lizard()
        {
            name = "Lizard";
            string spock = "Spock";
            string paper = "Paper";
            List<string> beats = new List<string>();

            beats.Add(spock);
            beats.Add(paper);
        }

        //member methods
    }
}
