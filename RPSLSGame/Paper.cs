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
        public Paper(Scissor scissor, Lizard lizard)
        {
            name = "Paper";
            string[] losesTo = { scissor.name, lizard.name };
        }

        //member methods
    }
}
