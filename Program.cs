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

            string userGuess = " ";
            int gameCounter = 0;

            AskPlayerForANumber(ref userGuess, ref gameCounter);

            DetermineGameMessgae(ref userGuess, ref gameCounter);
            
    

            
            
            // When the user guesses -1, the application should exit.
            // The game should provide feedback that the secret number is > or < any incorrect guesses.
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

        static void DetermineGameMessgae(ref string userInput, ref int gameCounter)
        {
            if(Convert.ToInt32(userInput) == 7)
                    Console.WriteLine("You are a winner!");

            else if(Convert.ToInt32(userInput) == 0)
                 Console.WriteLine("Here are some user instructions Try Again");

                 if(gameCounter < 2)
                 {
                    AskPlayerForANumber(ref userInput, ref gameCounter);
                    DetermineGameMessgae(ref userInput, ref gameCounter);
                 }
                   
            else
                if(gameCounter < 2)
                    {
                        Console.WriteLine("You guessed the wrong number Try Again");
                        AskPlayerForANumber(ref userInput, ref gameCounter);
                        DetermineGameMessgae(ref userInput, ref gameCounter);
                    }
                    else
                    Console.WriteLine("Game Over");
         
                    
        }
        
    }
}
