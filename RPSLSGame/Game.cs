using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSGame
{
    class Game
    {
        //member variables
        Human playerOne;
        Human playerTwo;
        Computer computer;
        Player player;

        //constructor
        public Game()
        {
            playerOne = new Human();
            playerTwo = new Human();
            computer = new Computer();
            player = new Player();
        }  
        //member methods

        public void DisplayRules()
        {
            Console.WriteLine("Select single player or multiplayer then choose your gestures.\n" + "Player with best two out of three wins.\n");
        }

        public void SelectPlayers()
        {
            int singlePlayer = 1;
            int multiPlayer = 2;

            Console.WriteLine($"Select {singlePlayer} for Single Player or {multiPlayer} for MultiPlayer.");            
            int userInput = Int32.Parse(Console.ReadLine());

            if (userInput == singlePlayer)
            {
                Console.WriteLine("You have chosen Single Player.\n");

                if (userInput == singlePlayer)
                {
                    playerOne.FirstPlayerSelectGesture();
                    computer.ComputerSelectGesture();
                }
                else
                {
                    Console.WriteLine($"You have chosen MultiPlayer.\n");
                    playerOne.FirstPlayerSelectGesture();
                    playerTwo.SecondPlayerSelectGesture();
                }
            }            
        }
        

        //1. Display the rules
        //2. Single Player or Multiplayer?
        //3. Who goes first? Choose a gesture.
        //4. Next person chooses a gesture.
        //5. Make a comparison between the two gestures.
        //6. Whoever has the winning gesture wins the round.
        //7. Repeat until best of three.
        //8. Display who the winner is!
    }
}
