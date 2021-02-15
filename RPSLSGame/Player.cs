﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSGame
{
    class Player
    {
        //member variables
        public string playerName;
        public string playerGesture;
        public int totalWins;
        public List<Gesture> gestures;


        //constructor
        public Player()
        {
            totalWins = 0;
            gestures = new List<Gesture>();

            Rock rock = new Rock();
            Paper paper = new Paper();
            Scissors scissor = new Scissors();
            Lizard lizard = new Lizard();
            Spock spock = new Spock();

            gestures.Add(rock);
            gestures.Add(paper);
            gestures.Add(scissor);
            gestures.Add(lizard);
            gestures.Add(spock);
        }
        //member methods

        public virtual void ChooseGesture()
        {

        }
        


    }
}
