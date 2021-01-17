using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSGame
{
    class Scissor: Gesture
    {
        //member variables

        //constructor
        public Scissor(Rock rock, Spock spock)
        {
            name = "Scissor";
            string[] losesTo = { rock.name, spock.name };
        }

        //member methods
    }
}
