﻿using System;
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

        //constructor
        public Game()
        {
            playerOne = new Human();
            playerTwo = new Human();
            computer = new Computer();            
        }  
        //member methods

        public void DisplayRules()
        {
            Console.WriteLine("Select single player or multiplayer then choose your gestures.\n" + "Player with best two out of three wins.\n");
        }

        public void RunGame()
        {
            string singlePlayer = "1";
            string multiPlayer = "2";

            Console.WriteLine($"Select {singlePlayer} for Single Player or {multiPlayer} for MultiPlayer.\n");
            string userInput = Console.ReadLine();

            if (userInput != singlePlayer && userInput != multiPlayer)
            {
                Console.WriteLine("Invalid selection please try again\n");
                RunGame();
            }
            else
            {
                if (userInput == singlePlayer)
                {
                    Console.WriteLine("You have chosen Single Player.\n");

                    while (playerOne.totalWins < 3 && computer.totalWins < 3)
                    {
                        playerOne.FirstPlayerSelectGesture();
                        computer.ComputerSelectGesture();
                        CompareComputerGestures();
                    }
                        if (playerOne.totalWins > computer.totalWins)
                        {
                            Console.WriteLine("\nPlayer one wins the game!");
                        }
                        else
                        {
                            Console.WriteLine("\nThe computer wins.");
                        }
                
                }            
                else if (userInput == multiPlayer)
                {
                    Console.WriteLine($"You have chosen MultiPlayer.\n");

                    while (playerOne.totalWins < 3 && playerTwo.totalWins < 3)
                    {
                        playerOne.FirstPlayerSelectGesture();
                        playerTwo.SecondPlayerSelectGesture();
                        CompareHumanGestures();
                    }
                        if (playerOne.totalWins > playerTwo.totalWins)
                        {
                            Console.WriteLine("\nPlayer one wins the game!");
                        }
                        else
                        {
                            Console.WriteLine("\nPlayer two wins the game!");
                        }                
                }

            }

        }        
        public void CompareHumanGestures()
        {
            if (playerOne.playerGesture == playerTwo.playerGesture)
            {
                Console.WriteLine("It's a tie");
            }
            else if (playerOne.playerGesture == "Rock" && playerTwo.playerGesture == "Scissor" || playerOne.playerGesture == "Scissor" && playerTwo.playerGesture == "Rock")
            {
                if (playerOne.playerGesture == "Scissor" && playerTwo.playerGesture == "Rock")
                {
                    Console.WriteLine("Rock crushes Scissors\n");
                    Console.WriteLine("Player two wins this round");
                    playerTwo.totalWins++;
                }
                else
                {
                    Console.WriteLine("Rock crushes Scissors\n");
                    Console.WriteLine("Player one wins this round");
                    playerOne.totalWins++;
                }
            }
            else if (playerOne.playerGesture == "Rock" && playerTwo.playerGesture == "Lizard" || playerOne.playerGesture == "Lizard" && playerTwo.playerGesture == "Rock")
            {
                if (playerOne.playerGesture == "Lizard" && playerTwo.playerGesture == "Rock")
                {
                    Console.WriteLine("Rock crushes Lizard\n");
                    Console.WriteLine("Player two wins this round");
                    playerTwo.totalWins++;
                }
                else
                {
                    Console.WriteLine("Rock crushes Lizard\n");
                    Console.WriteLine("Player one wins this round");
                    playerOne.totalWins++;
                }
            }
            else if (playerOne.playerGesture == "Paper" && playerTwo.playerGesture == "Rock" || playerOne.playerGesture == "Rock" && playerTwo.playerGesture == "Paper")
            {
                if (playerOne.playerGesture == "Rock" && playerTwo.playerGesture == "Paper")
                {
                    Console.WriteLine("Paper covers Rock\n");
                    Console.WriteLine("Player two wins this round");
                    playerTwo.totalWins++;
                }
                else
                {
                    Console.WriteLine("Paper covers Rock\n");
                    Console.WriteLine("Player one wins this round");
                    playerOne.totalWins++;
                }
            }
            else if (playerOne.playerGesture == "Paper" && playerTwo.playerGesture == "Spock" || playerOne.playerGesture == "Spock" && playerTwo.playerGesture == "Paper")
            {
                if (playerOne.playerGesture == "Spock" && playerTwo.playerGesture == "Paper")
                {
                    Console.WriteLine("Paper disapproves Spock\n");
                    Console.WriteLine("Player two wins this round");
                    playerTwo.totalWins++;
                }
                else
                {
                    Console.WriteLine("Paper disapproves Spock\n");
                    Console.WriteLine("Player one wins this round");
                    playerOne.totalWins++;
                }
            }
            else if (playerOne.playerGesture == "Scissor" && playerTwo.playerGesture == "Paper" || playerOne.playerGesture == "Paper" && playerTwo.playerGesture == "Scissor")
            {
                if (playerOne.playerGesture == "Paper" && playerTwo.playerGesture == "Scissor")
                {
                    Console.WriteLine("Scissor cuts Paper\n");
                    Console.WriteLine("Player two wins this round");
                    playerTwo.totalWins++;
                }
                else 
                {
                    Console.WriteLine("Scissor cuts Paper\n");
                    Console.WriteLine("Player one wins this round");
                    playerOne.totalWins++;
                }
            }
            else if (playerOne.playerGesture == "Scissor" && playerTwo.playerGesture == "Lizard" || playerOne.playerGesture == "Lizard" && playerTwo.playerGesture == "Scissor")
            {
                if (playerOne.playerGesture == "Lizard" && playerTwo.playerGesture == "Scissor")
                {
                    Console.WriteLine("Scissor decapitates Lizard\n");
                    Console.WriteLine("Player two wins this round");
                    playerTwo.totalWins++;
                }
                else
                {
                    Console.WriteLine("Scissor decapitates Lizard\n");
                    Console.WriteLine("Player one wins this round");
                    playerOne.totalWins++;
                }
            }
            else if (playerOne.playerGesture == "Lizard" && playerTwo.playerGesture == "Spock" || playerOne.playerGesture == "Spock" && playerTwo.playerGesture == "Lizard")
            {
                if (playerOne.playerGesture == "Spock" && playerTwo.playerGesture == "Lizard")
                {
                    Console.WriteLine("Lizard poisons Spock\n");
                    Console.WriteLine("Player two wins this round");
                    playerTwo.totalWins++;
                }
                else
                {
                    Console.WriteLine("Lizard poisons Spock\n");
                    Console.WriteLine("Player one wins this round");
                    playerOne.totalWins++;
                }
            }
            else if (playerOne.playerGesture == "Lizard" && playerTwo.playerGesture == "Paper" || playerOne.playerGesture == "Paper" && playerTwo.playerGesture == "Lizard")
            {
                if (playerOne.playerGesture == "Paper" && playerTwo.playerGesture == "Lizard")
                {
                    Console.WriteLine("Lizard eats Paper\n");
                    Console.WriteLine("Player two wins this round");
                    playerTwo.totalWins++;
                }
                else
                {
                    Console.WriteLine("Lizard eats Paper\n");
                    Console.WriteLine("Player one wins this round");
                    playerOne.totalWins++;
                }
            }
            else if (playerOne.playerGesture == "Spock" && playerTwo.playerGesture == "Scissor" || playerOne.playerGesture == "Scissor" && playerTwo.playerGesture == "Spock")
            {
                if (playerOne.playerGesture == "Scissor" && playerTwo.playerGesture == "Spock")
                {
                    Console.WriteLine("Spock smashes Scissor\n");
                    Console.WriteLine("Player two wins this round");
                    playerTwo.totalWins++;
                }
                else
                {
                    Console.WriteLine("Spock smashes Scissor\n");
                    Console.WriteLine("Player one wins this round");
                    playerOne.totalWins++;
                }
            }
            else if (playerOne.playerGesture == "Spock" && playerTwo.playerGesture == "Rock" || playerOne.playerGesture == "Rock" && playerTwo.playerGesture == "Spock")
            {
                if (playerOne.playerGesture == "Rock" && playerTwo.playerGesture == "Spock")
                {
                    Console.WriteLine("Spock vaporizes Rock\n");
                    Console.WriteLine("Player two wins this round");
                    playerTwo.totalWins++;
                }
                else
                {
                    Console.WriteLine("Spock vaporizes Rock\n");
                    Console.WriteLine("Player one wins this round");
                    playerOne.totalWins++;
                }
            }
        }
        public void CompareComputerGestures()
        {
            if (playerOne.playerGesture == computer.playerGesture)
            {
                Console.WriteLine("It's a tie");
            }
            else if (playerOne.playerGesture == "Rock" && computer.playerGesture == "Scissor" || playerOne.playerGesture == "Scissor" && computer.playerGesture == "Rock")
            {
                if (playerOne.playerGesture == "Scissor" && computer.playerGesture == "Rock")
                {
                    Console.WriteLine("Rock crushes Scissors\n");
                    Console.WriteLine("Computer wins this round");
                    computer.totalWins++;
                }
                else
                {
                    Console.WriteLine("Rock crushes Scissors\n");
                    Console.WriteLine("Player one wins this round");
                    playerOne.totalWins++;
                }
            }
            else if (playerOne.playerGesture == "Rock" && computer.playerGesture == "Lizard" || playerOne.playerGesture == "Lizard" && computer.playerGesture == "Rock")
            {
                if (playerOne.playerGesture == "Lizard" && computer.playerGesture == "Rock")
                {
                    Console.WriteLine("Rock crushes Lizard\n");
                    Console.WriteLine("Computer wins this round");
                    computer.totalWins++;
                }
                else
                {
                    Console.WriteLine("Rock crushes Lizard\n");
                    Console.WriteLine("Player one wins this round");
                    playerOne.totalWins++;
                }
            }
            else if (playerOne.playerGesture == "Paper" && computer.playerGesture == "Rock" || playerOne.playerGesture == "Rock" && computer.playerGesture == "Paper")
            {
                if (playerOne.playerGesture == "Rock" && computer.playerGesture == "Paper")
                {
                    Console.WriteLine("Paper covers Rock\n");
                    Console.WriteLine("Computer wins this round");
                    computer.totalWins++;
                }
                else
                {
                    Console.WriteLine("Paper covers Rock\n");
                    Console.WriteLine("Player one wins this round");
                    playerOne.totalWins++;
                }
            }
            else if (playerOne.playerGesture == "Paper" && computer.playerGesture == "Spock" || playerOne.playerGesture == "Spock" && computer.playerGesture == "Paper")
            {
                if (playerOne.playerGesture == "Spock" && computer.playerGesture == "Paper")
                {
                    Console.WriteLine("Paper disapproves Spock\n");
                    Console.WriteLine("Computer wins this round");
                    computer.totalWins++;
                }
                else
                {
                    Console.WriteLine("Paper disapproves Spock\n");
                    Console.WriteLine("Player one wins this round");
                    playerOne.totalWins++;
                }
            }
            else if (playerOne.playerGesture == "Scissor" && computer.playerGesture == "Paper" || playerOne.playerGesture == "Paper" && computer.playerGesture == "Scissor")
            {
                if (playerOne.playerGesture == "Paper" && computer.playerGesture == "Scissor")
                {
                    Console.WriteLine("Scissor cuts Paper\n");
                    Console.WriteLine("Computer wins this round");
                    computer.totalWins++;
                }
                else
                {
                    Console.WriteLine("Scissor cuts Paper\n");
                    Console.WriteLine("Player one wins this round");
                    playerOne.totalWins++;
                }
            }
            else if (playerOne.playerGesture == "Scissor" && computer.playerGesture == "Lizard" || playerOne.playerGesture == "Lizard" && computer.playerGesture == "Scissor")
            {
                if (playerOne.playerGesture == "Lizard" && computer.playerGesture == "Scissor")
                {
                    Console.WriteLine("Scissor decapitates Lizard\n");
                    Console.WriteLine("Computer wins this round");
                    computer.totalWins++;
                }
                else
                {
                    Console.WriteLine("Scissor decapitates Lizard\n");
                    Console.WriteLine("Player one wins this round");
                    playerOne.totalWins++;
                }
            }
            else if (playerOne.playerGesture == "Lizard" && computer.playerGesture == "Spock" || playerOne.playerGesture == "Spock" && computer.playerGesture == "Lizard")
            {
                if (playerOne.playerGesture == "Spock" && computer.playerGesture == "Lizard")
                {
                    Console.WriteLine("Lizard poisons Spock\n");
                    Console.WriteLine("Computer wins this round");
                    computer.totalWins++;
                }
                else
                {
                    Console.WriteLine("Lizard poisons Spock\n");
                    Console.WriteLine("Player one wins this round");
                    playerOne.totalWins++;
                }
            }
            else if (playerOne.playerGesture == "Lizard" && computer.playerGesture == "Paper" || playerOne.playerGesture == "Paper" && computer.playerGesture == "Lizard")
            {
                if (playerOne.playerGesture == "Paper" && computer.playerGesture == "Lizard")
                {
                    Console.WriteLine("Lizard eats Paper\n");
                    Console.WriteLine("Computer wins this round");
                    computer.totalWins++;
                }
                else
                {
                    Console.WriteLine("Lizard eats Paper\n");
                    Console.WriteLine("Player one wins this round");
                    playerOne.totalWins++;
                }
            }
            else if (playerOne.playerGesture == "Spock" && computer.playerGesture == "Scissor" || playerOne.playerGesture == "Scissor" && computer.playerGesture == "Spock")
            {
                if (playerOne.playerGesture == "Scissor" && computer.playerGesture == "Spock")
                {
                    Console.WriteLine("Spock smashes Scissor\n");
                    Console.WriteLine("Computer wins this round");
                    computer.totalWins++;
                }
                else
                {
                    Console.WriteLine("Spock smashes Scissor\n");
                    Console.WriteLine("Player one wins this round");
                    playerOne.totalWins++;
                }
            }
            else if (playerOne.playerGesture == "Spock" && computer.playerGesture == "Rock" || playerOne.playerGesture == "Rock" && computer.playerGesture == "Spock")
            {
                if (playerOne.playerGesture == "Rock" && computer.playerGesture == "Spock")
                {
                    Console.WriteLine("Spock vaporizes Rock\n");
                    Console.WriteLine("Computer wins this round");
                    computer.totalWins++;
                }
                else
                {
                    Console.WriteLine("Spock vaporizes Rock\n");
                    Console.WriteLine("Player one wins this round");
                    playerOne.totalWins++;
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
