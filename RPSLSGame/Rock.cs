﻿using System;
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
        public Rock()
        {
            name = "Rock";
            string scissor = "Scissors";
            string lizard = "Lizard";
            List<string> beats = new List<string>();

            beats.Add(scissor);
            beats.Add(lizard);
            
        }

        //member methods
        
        

    }
}
