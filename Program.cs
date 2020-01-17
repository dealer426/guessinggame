﻿using System;

namespace guessinggame
{
    class Program
    {
        static void Main(string[] args)
        {
            // When the user guesses 7, the game announces they have won. All other numbers lose.
            // When the user guesses 0, the game provides instructions for the user.
            // After guessing, the user can take one more guess (unless they won!)
            // When the user guesses -1, the application should exit.
            // The game should provide feedback that the secret number is > or < any incorrect guesses.

            string userGuess = " ";
            int gameCounter = 0;
            bool isWinner = false;

            AskPlayerForANumber(ref userGuess, ref gameCounter);

            DetermineGameMessgae(ref userGuess, ref gameCounter, ref isWinner);
            
            if(isWinner)
            Console.WriteLine( "You are a Winner!");
            else if (!isWinner && gameCounter <2)
                   {
                        AskPlayerForANumber(ref userGuess, ref gameCounter);
                        DetermineGameMessgae(ref userGuess, ref gameCounter, ref isWinner);
                        if(isWinner)
                                Console.WriteLine( "You are a Winner!");
                        else
                                Console.WriteLine("You Lost!");
                    }
            else
                Console.WriteLine("You Lost!");
            


             
            
           
            
            // The number should be random, instead of always 7.

            // Stretch task: Give the user 3 tries before announcing they have lost.


            Console.ReadKey();
        }

        static void AskPlayerForANumber(ref string userInput, ref int gameCounter)
        {
            System.Console.Write("Please guess a neber between 1 & 10:");
            userInput = Console.ReadLine();
            ++gameCounter;
        }

        static void DetermineGameMessgae(ref string userInput, ref int gameCounter, ref bool checkWinner)
        {

            if (Convert.ToInt32(userInput) == 7)
                {
                    checkWinner = true;
                }

            else if (Convert.ToInt32(userInput) == -1)
                {
                    gameCounter = 2;
                }
                
            else if (Convert.ToInt32(userInput) == 0)
                {
                     Console.WriteLine("Here are some user instructions");
                     checkWinner = false;
                }

                else
                {
                    checkWinner = false;
                }

                     
        }
        
    }
}
