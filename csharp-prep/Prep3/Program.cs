using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;

        while (playAgain)
        {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guess = -1;
        int guessCount = 0;


        while (guess != magicNumber)
                {
                Console.WriteLine("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (magicNumber > guess) 
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess) 
                {
                    Console.WriteLine("Lower");
                }
                else 
                {
                    Console.WriteLine($"You guess it! It took you {guessCount} guesses.");
                }
            
            }
        Console.WriteLine("Do you want to play again? (yes/no): ");
        string response = Console.ReadLine().Trim().ToLower();

        if (response != "yes" && response != "y")
            {
                playAgain = false;
                Console.WriteLine("Thanks for playing!");
            }
        }
    }
}
