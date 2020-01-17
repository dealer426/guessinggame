using System;

namespace guessinggame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("//When the user guesses 7, the game announces they have won. All other numbers lose. \n// When the user guesses 0, the game provides instructions for the user. \n/ After guessing, the user can take one more guess (unless they won!) \n// When the user guesses -1, the application should exit. \n// The game should provide feedback that the secret number is > or < any incorrect guesses. \n// The number should be random, instead of always 7. \n// Stretch task: Give the user 3 tries before announcing they have lost.\n\n\n");
            
            string userGuess = " ";
            int gameCounter = 0;
            int gameNumber = 0;
            bool isWinner = false;

            GetRandomNumberForGame(ref gameNumber);

            while(PlayerHasNotReached3Tries(gameCounter) && PlayerHasGuessedWrongNumber(isWinner))
            {
               
                AskPlayerForANumber(ref userGuess, ref gameCounter);
                DetermineGameMessgae(ref userGuess, ref gameCounter, ref isWinner, gameNumber);
                IsNumberHigherOrLower(ref userGuess, gameNumber);

            }

            if(isWinner)
                Console.WriteLine( "You are a Winner!");
            else
                Console.WriteLine("You Lost!");
            

            Console.ReadKey();
        }

        static void AskPlayerForANumber(ref string userInput, ref int gameCounter)
        {
            System.Console.Write("Please guess a neber between 1 & 10:");
            userInput = Console.ReadLine();
            ++gameCounter;
        }

        static void DetermineGameMessgae(ref string userInput, ref int gameCounter, ref bool checkWinner,  int gameNumber)
        {
            if (Convert.ToInt32(userInput) == gameNumber)
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

        static void IsNumberHigherOrLower(ref string userInput, int gameNumber)
        {
            Console.WriteLine((Convert.ToInt32(userInput) > gameNumber) ? "Guess a Lower Number!" : "Guess a Higher Number!");
        }

        static void GetRandomNumberForGame(ref int gameNumber)
        {
            Random rnd = new Random();
            int[] gameNumbers = {1,2,3,4,5,6,7,8,9,10};
            gameNumber = rnd.Next(gameNumbers.Length);
        }
        
        static bool PlayerHasNotReached3Tries(int gameCounter)
        {
            if(gameCounter < 3)
            return true;
            else
            return false;
        }

        static bool PlayerHasGuessedWrongNumber(bool isWinner)
        {
            if(isWinner)
            return false;
            else
            return true;
        }


    }
}
