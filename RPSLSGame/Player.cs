using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSGame
{
    public class Player
    {
        //member variables
        public string playerName;
        List<Gesture> gestures;
        Rock rock;
        Scissor scissor;
        Paper paper;
        Lizard lizard;
        Spock spock;

        //constructor
        public Player()
        {            
            gestures = new List<Gesture>();

            rock = new Rock();
            paper = new Paper();
            scissor = new Scissor();
            lizard = new Lizard();
            spock = new Spock();

            gestures.Add(rock);
            gestures.Add(paper);
            gestures.Add(scissor);
            gestures.Add(lizard);
            gestures.Add(spock);
        }
        //member methods


    }
}
