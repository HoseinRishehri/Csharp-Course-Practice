using System;

namespace Guess_random_number
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int number = 0;
            int round = 0;
            string playAgain = null;

            while (playAgain != "n")
            {
                Random random = new Random();
                var randomNumber = random.Next(1, 101);
                Console.Clear();
                do
                {
                    Console.WriteLine("Guess a number between 1 - 100 :");
                    // number = Convert.ToInt32(Console.ReadLine());
                    number = randomNumber;
                    Console.WriteLine($"Guess: {number}");

                    if (number > randomNumber)
                    {
                        Console.WriteLine($"{number} is too high!");
                    }
                    else if (number < randomNumber)
                    {
                        Console.WriteLine($"{number} is too low!");
                    }

                    round++;
                } while (randomNumber != number);

                Console.WriteLine($"Number: {randomNumber}");
                Console.WriteLine($"YOU WIN in {round} Rounds!");
                Console.WriteLine("Would you like to play again? (y/n):");
                playAgain = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("Good BYE!");

        }
    }
}
