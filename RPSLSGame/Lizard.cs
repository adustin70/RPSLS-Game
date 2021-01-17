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
        public Lizard(Rock rock, Scissor scissor)
        {
            name = "Lizard";
            string[] losesTo = { rock.name, scissor.name };
        }

        //member methods
    }
}
