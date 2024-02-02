using System;

namespace Easy_Project_v06
{
    internal class Program
    {
        //-------------------------------------------------------------------------------
        /* This code made by Anar Abasov
         * Number Guessing Game: Create a game where the computer generates a random number, and the user tries to guess it within a certain number of attempts.*/
        //-------------------------------------------------------------------------------

        static void Main(string[] args)
        {
            RunNumberGuessingGame();
        }

        static void RunNumberGuessingGame()
        {
            int guess = -1;
            int count = 0;

            Random rnd = new Random();
            int randNum = rnd.Next(1, 101);

            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("I'm thinking of a number between 1 and 100.");

            while (guess != randNum)
            {
                guess = GetGuessFromUser();
                count++;

                if (guess < randNum)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (guess > randNum)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed the number {randNum} in {count} attempts.");
                }
            }

            Console.ReadKey();
        }

        static int GetGuessFromUser()
        {
            int guess;
            while (true)
            {
                Console.Write("Guess the number: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out guess))
                {
                    if (guess >= 1 && guess <= 100)
                    {
                        return guess;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number between 1 and 100.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }
    }
}
