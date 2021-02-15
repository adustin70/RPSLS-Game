using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSGame
{
    class Human : Player
    {
        //member variables
        string userInput = "";

        //constructor
        

        //member methods
        public override void ChooseGesture()
        {
            Console.WriteLine($"{playerName} Choose a gesture.");
            
            for (int i = 0; i < gestures.Count; i++)
            {
                Console.WriteLine($"{gestures[i].name}");
            }

            userInput = Console.ReadLine();
            ValidateGestureChoice();
        }  

        public void ValidateGestureChoice()
        {
            bool selectionFound = false;

            foreach (Gesture selectedGesture in gestures)
            {
                if (selectedGesture.name == userInput)
                {
                    selectionFound = true;
                }
            }
            if (selectionFound)
            {
                playerGesture = userInput;
                Console.WriteLine(userInput);
            }
            else
            {
                Console.WriteLine("Invalid choice try again");
                ChooseGesture();
            }
        }
    }
}
