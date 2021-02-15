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
        Player playerOne;
        Player playerTwo;
        string singlePlayer = "1";
        string multiPlayer = "2";
        string userInput = "";

        //constructor
        public Game()
        {
            DecideIfSingleOrMultiplayer();            
        }  
        //member methods

        public void DecideIfSingleOrMultiplayer()
        {
            Console.WriteLine($"Pick {singlePlayer} for Singleplayer or {multiPlayer} for Multiplayer\n");
            userInput = Console.ReadLine();
            ValidateUserInput();
            
            if (userInput == "1")
            {
                playerOne = new Human();
                playerOne.playerName = "Player One";
                playerTwo = new Computer();
                playerTwo.playerName = "Computer";
                Console.WriteLine("You have chosen Singleplayer.\n");
            }
            else
            {
                playerOne = new Human();
                playerOne.playerName = "Player One";
                playerTwo = new Human();
                playerTwo.playerName = "Player Two";
                Console.WriteLine($"You have chosen Multiplayer.\n");
            }
        }

        public void ValidateUserInput()
        {
            while (userInput != singlePlayer && userInput != multiPlayer)
            {
                Console.WriteLine("Invalid selection please try again\n");
            }
        }

        public void DisplayRules()
        {
            Console.WriteLine("Select single player or multiplayer then choose your gestures.\n" + "First player to three wins will win the game.\n");
        }

        public void CompareGestures()
        {
            if (playerOne.playerGesture == playerTwo.playerGesture)
            {
                Console.WriteLine("It's a tie");
            }
            else if (playerOne.playerGesture == "Rock" && playerTwo.playerGesture == "Scissors" || playerOne.playerGesture == "Scissors" && playerTwo.playerGesture == "Rock")
            {
                if (playerOne.playerGesture == "Scissors" && playerTwo.playerGesture == "Rock")
                {
                    Console.WriteLine("Rock crushes Scissors\n");
                    Console.WriteLine($"{playerTwo.playerName} wins this round");
                    playerTwo.totalWins++;
                }
                else
                {
                    Console.WriteLine("Rock crushes Scissors\n");
                    Console.WriteLine($"{playerOne.playerName} wins this round");
                    playerOne.totalWins++;
                }
            }
            else if (playerOne.playerGesture == "Rock" && playerTwo.playerGesture == "Lizard" || playerOne.playerGesture == "Lizard" && playerTwo.playerGesture == "Rock")
            {
                if (playerOne.playerGesture == "Lizard" && playerTwo.playerGesture == "Rock")
                {
                    Console.WriteLine("Rock crushes Lizard\n");
                    Console.WriteLine($"{playerTwo.playerName} wins this round");
                    playerTwo.totalWins++;
                }
                else
                {
                    Console.WriteLine("Rock crushes Lizard\n");
                    Console.WriteLine($"{playerOne.playerName} wins this round");
                    playerOne.totalWins++;
                }
            }
            else if (playerOne.playerGesture == "Paper" && playerTwo.playerGesture == "Rock" || playerOne.playerGesture == "Rock" && playerTwo.playerGesture == "Paper")
            {
                if (playerOne.playerGesture == "Rock" && playerTwo.playerGesture == "Paper")
                {
                    Console.WriteLine("Paper covers Rock\n");
                    Console.WriteLine($"{playerTwo.playerName} wins this round");
                    playerTwo.totalWins++;
                }
                else
                {
                    Console.WriteLine("Paper covers Rock\n");
                    Console.WriteLine($"{playerOne.playerName} wins this round");
                    playerOne.totalWins++;
                }
            }
            else if (playerOne.playerGesture == "Paper" && playerTwo.playerGesture == "Spock" || playerOne.playerGesture == "Spock" && playerTwo.playerGesture == "Paper")
            {
                if (playerOne.playerGesture == "Spock" && playerTwo.playerGesture == "Paper")
                {
                    Console.WriteLine("Paper disapproves Spock\n");
                    Console.WriteLine($"{playerTwo.playerName} wins this round");
                    playerTwo.totalWins++;
                }
                else
                {
                    Console.WriteLine("Paper disapproves Spock\n");
                    Console.WriteLine($"{playerOne.playerName} wins this round");
                    playerOne.totalWins++;
                }
            }
            else if (playerOne.playerGesture == "Scissors" && playerTwo.playerGesture == "Paper" || playerOne.playerGesture == "Paper" && playerTwo.playerGesture == "Scissors")
            {
                if (playerOne.playerGesture == "Paper" && playerTwo.playerGesture == "Scissors")
                {
                    Console.WriteLine("Scissor cuts Paper\n");
                    Console.WriteLine($"{playerTwo.playerName} wins this round");
                    playerTwo.totalWins++;
                }
                else
                {
                    Console.WriteLine("Scissor cuts Paper\n");
                    Console.WriteLine($"{playerOne.playerName} wins this round");
                    playerOne.totalWins++;
                }
            }
            else if (playerOne.playerGesture == "Scissors" && playerTwo.playerGesture == "Lizard" || playerOne.playerGesture == "Lizard" && playerTwo.playerGesture == "Scissors")
            {
                if (playerOne.playerGesture == "Lizard" && playerTwo.playerGesture == "Scissors")
                {
                    Console.WriteLine("Scissor decapitates Lizard\n");
                    Console.WriteLine($"{playerTwo.playerName} wins this round");
                    playerTwo.totalWins++;
                }
                else
                {
                    Console.WriteLine("Scissor decapitates Lizard\n");
                    Console.WriteLine($"{playerOne.playerName} wins this round");
                    playerOne.totalWins++;
                }
            }
            else if (playerOne.playerGesture == "Lizard" && playerTwo.playerGesture == "Spock" || playerOne.playerGesture == "Spock" && playerTwo.playerGesture == "Lizard")
            {
                if (playerOne.playerGesture == "Spock" && playerTwo.playerGesture == "Lizard")
                {
                    Console.WriteLine("Lizard poisons Spock\n");
                    Console.WriteLine($"{playerTwo.playerName} wins this round");
                    playerTwo.totalWins++;
                }
                else
                {
                    Console.WriteLine("Lizard poisons Spock\n");
                    Console.WriteLine($"{playerOne.playerName} wins this round");
                    playerOne.totalWins++;
                }
            }
            else if (playerOne.playerGesture == "Lizard" && playerTwo.playerGesture == "Paper" || playerOne.playerGesture == "Paper" && playerTwo.playerGesture == "Lizard")
            {
                if (playerOne.playerGesture == "Paper" && playerTwo.playerGesture == "Lizard")
                {
                    Console.WriteLine("Lizard eats Paper\n");
                    Console.WriteLine($"{playerTwo.playerName} wins this round");
                    playerTwo.totalWins++;
                }
                else
                {
                    Console.WriteLine("Lizard eats Paper\n");
                    Console.WriteLine($"{playerOne.playerName} wins this round");
                    playerOne.totalWins++;
                }
            }
            else if (playerOne.playerGesture == "Spock" && playerTwo.playerGesture == "Scissors" || playerOne.playerGesture == "Scissors" && playerTwo.playerGesture == "Spock")
            {
                if (playerOne.playerGesture == "Scissors" && playerTwo.playerGesture == "Spock")
                {
                    Console.WriteLine("Spock smashes Scissor\n");
                    Console.WriteLine($"{playerTwo.playerName} wins this round");
                    playerTwo.totalWins++;
                }
                else
                {
                    Console.WriteLine("Spock smashes Scissors\n");
                    Console.WriteLine($"{playerOne.playerName} wins this round");
                    playerOne.totalWins++;
                }
            }
            else if (playerOne.playerGesture == "Spock" && playerTwo.playerGesture == "Rock" || playerOne.playerGesture == "Rock" && playerTwo.playerGesture == "Spock")
            {
                if (playerOne.playerGesture == "Rock" && playerTwo.playerGesture == "Spock")
                {
                    Console.WriteLine("Spock vaporizes Rock\n");
                    Console.WriteLine($"{playerTwo.playerName} wins this round");
                    playerTwo.totalWins++;
                }
                else
                {
                    Console.WriteLine("Spock vaporizes Rock\n");
                    Console.WriteLine($"{playerOne.playerName} wins this round");
                    playerOne.totalWins++;
                }
            }
        }

        public void RunGame()
        {
            DisplayRules();


            while (playerOne.totalWins < 3 && playerTwo.totalWins < 3)
            {
                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();
                CompareGestures();
                
            }
            if (playerOne.totalWins > playerTwo.totalWins)
            {
                Console.WriteLine($"\n{playerOne.playerName} wins the game!");
            }
            else
            {
                Console.WriteLine($"\n{playerTwo.playerName} wins the game!");
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
