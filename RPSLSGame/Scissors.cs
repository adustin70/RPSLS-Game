using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSGame
{
    class Scissors: Gesture
    {
        //member variables

        //constructor
        public Scissors()
        {
            name = "Scissors";
            string paper = "Paper";
            string lizard = "Lizard";
            List<string> beats = new List<string>();

            beats.Add(paper);
            beats.Add(lizard);
        }

        //member methods
    }
}
