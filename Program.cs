using System;

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
            // The number should be random, instead of always 7.

            string userGuess = " ";
            int gameCounter = 0;
            bool isWinner = false;

            Random rnd = new Random();
            int[] gameNumbers = {1,2,3,4,5,6,7,8,9,10};
            int gameNumber = rnd.Next(gameNumbers.Length);

            AskPlayerForANumber(ref userGuess, ref gameCounter);

            DetermineGameMessgae(ref userGuess, ref gameCounter, ref isWinner, gameNumber);

            if(isWinner)
                Console.WriteLine( "You are a Winner!");
            
            else if(!isWinner && gameCounter < 2)
                   {
                        IsNumberHigherOrLower(ref userGuess);
                        AskPlayerForANumber(ref userGuess, ref gameCounter);
                        DetermineGameMessgae(ref userGuess, ref gameCounter, ref isWinner, gameNumber);
                        
                        if(isWinner)
                                Console.WriteLine( "You are a Winner!");
                        else
                                Console.WriteLine("You Lost!");
                    }
            else
                Console.WriteLine("You Lost!");
            

           

            // Stretch task: Give the user 3 tries before announcing they have lost.


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

        static void IsNumberHigherOrLower(ref string userInput)
        {
            Console.WriteLine((Convert.ToInt32(userInput) > 7) ? "Guess a Lower Number!" : "Guess a Higher Number!");
        }
        
    }
}
