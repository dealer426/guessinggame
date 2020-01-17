using System;

namespace guessinggame
{
    class Program
    {
        static void Main(string[] args)
        {
            // When the user guesses 7, the game announces they have won. All other numbers lose.
            // When the user guesses 0, the game provides instructions for the user.

            string userGuess = " ";

            AskPlayerForANumber(ref userGuess);

            
            
            switch (userGuess)
            {
                case "7":
                Console.WriteLine("You are a winner!");
                break;

                case "0":
                Console.WriteLine("Here are some user instructions");
                break;

                default:
                Console.WriteLine("You guess the wrong number");
                break;
            }

            
            // After guessing, the user can take one more guess (unless they won!)
            // When the user guesses -1, the application should exit.
            // The game should provide feedback that the secret number is > or < any incorrect guesses.
            // The number should be random, instead of always 7.

            // Stretch task: Give the user 3 tries before announcing they have lost.


            Console.ReadKey();
        }

        static void AskPlayerForANumber(ref string userInput)
        {
            System.Console.Write("Please guess a neber between 1 & 10:");
            userInput = Console.ReadLine();
        }

        
    }
}
