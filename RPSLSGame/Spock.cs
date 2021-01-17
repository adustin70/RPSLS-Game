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
        public Spock(Lizard lizard, Paper paper)
        {
            name = "Spock";
            string[] losesTo = { lizard.name, paper.name };
        }

        //member methods
    }
}
