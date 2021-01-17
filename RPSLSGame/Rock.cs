using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSGame
{
    class Rock : Gesture
    {
        //member variables
        

        //constructor
        public Rock(Paper paper, Spock spock)
        {
            name = "Rock";
            string[] losesTo = { paper.name, spock.name};
        }

        //member methods
        
        

    }
}
