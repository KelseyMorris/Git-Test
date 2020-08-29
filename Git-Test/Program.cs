using System;

namespace Git_Test
{
    class Program
    {
        private static int FindNumber;

        static void Main(string[] args)
        {
            Console.WriteLine("Guess a letter between x and y");
             static int FindNumber()
            {
                int guess = 0;
                try
                {
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Not a valid guess.");
                    guess = FindNumber();
                }
                return guess;
            }
            int totalTries = 10;
            int numOfTries = 10;

            while (true)
            {
                int randomNumber = 0;
                int guess = FindNumber();
                numOfTries++;
                if (guess == randomNumber)
                {
                    
                    if (guess > randomNumber)
                        ;
                    {
                        Console.WriteLine("Too High!");
                    }
                    if (guess < randomNumber)
                    {
                        Console.WriteLine("Too Low!");
                    }
                    if (numOfTries == totalTries)
                    {
                        Console.WriteLine($"The number was: {randomNumber}");
                        break;
                    }
                    Console.Write($"You have {totalTries - numOfTries} atempts left. Try another guess: ");
                }
                else
                {
                    Console.WriteLine("Correct!");
                    break;
                }
            }
        }
    }
}