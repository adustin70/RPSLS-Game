using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSGame
{
    public abstract class Gesture
    {
        // member varaibles
        public string name;
        

        // constructor
        public Gesture()
        {
            
        }

        // member methods
        public void GestureLoses()
        {
            if (name != name)
            {
                Console.WriteLine("Winner");
            }
            else if (name == name)
            {
                Console.WriteLine("You tied");
            }
            //Feels off ^^ don't forget to test
        }

    }
}
                                                     /*is there a way to keep track of what a gesture loses to?*/
//*Rock crushes Scissors
//Scissors cuts Paper
//Paper covers Rock
//Rock crushes Lizard
//Lizard poisons Spock
//Spock smashes Scissors
//Scissors decapitates Lizard
//Lizard eats Paper
//Paper disproves Spock
//Spock vaporizes Rock