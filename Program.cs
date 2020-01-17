using System;

namespace guessinggame
{
    class Program
    {
        static void Main(string[] args)
        {
            // When the user guesses 7, the game announces they have won. All other numbers lose.

            string userGuess = "";

            System.Console.Write("Please guess a neber between 1 & 10:");
            userGuess = Console.ReadLine();
            int userGuessNumber = Convert.ToInt32(userGuess);

            Console.WriteLine((userGuessNumber == 7) ? "You Guessed Correctly" : "You guessed Incorrectly");



            // When the user guesses 0, the game provides instructions for the user.
            // After guessing, the user can take one more guess (unless they won!)
            // When the user guesses -1, the application should exit.
            // The game should provide feedback that the secret number is > or < any incorrect guesses.
            // The number should be random, instead of always 7.

            // Stretch task: Give the user 3 tries before announcing they have lost.



            Console.WriteLine("Hello World!");

            Console.ReadKey();
        }
    }
}
