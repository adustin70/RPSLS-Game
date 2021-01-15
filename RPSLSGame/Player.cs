using System;
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
        public List<string> gestures;
        

        //constructor
        public Player()
        {            
            gestures = new List<string>();

            Rock rock = new Rock();
            Paper paper = new Paper();
            Scissor scissor = new Scissor();
            Lizard lizard = new Lizard();
            Spock spock = new Spock();

            gestures.Add(rock.name);
            gestures.Add(paper.name);
            gestures.Add(scissor.name);
            gestures.Add(lizard.name);
            gestures.Add(spock.name);
        }
        //member methods


    }
}
