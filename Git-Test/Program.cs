using System;

namespace Git_Test
{
    class Program
    {
        private static int FindNumber;

        static void Main(string[] args)
        {
            Console.WriteLine("Guess a letter between x and y");//Asks the user an initial question
             static int FindNumber()
            {
                int guess = 0;
                try
                {
                    guess = Convert.ToInt32(Console.ReadLine());//This line must be included in c# programs excluding the guess =.
                }
                catch (Exception)
                {
                    Console.WriteLine("Not a valid guess.");//Tell the user it was the wrong number/letter.
                    guess = FindNumber();
                }
                return guess;
            }
            int totalTries = 10;//How many tries the user has.
            int numOfTries = 10;//How many attempts the user has.

            while (true)
            {
                int randomNumber = 0;
                int guess = FindNumber();
                numOfTries++;
                if (guess == randomNumber)//Generates a random number for the user to try to guess
                {
                    
                    if (guess > randomNumber)
                        ;
                    {
                        Console.WriteLine("Too High!");//Tell the user their guess was too high
                    }
                    if (guess < randomNumber)
                    {
                        Console.WriteLine("Too Low!");//Tells the user their guess was too low.
                    }
                    if (numOfTries == totalTries)
                    {
                        Console.WriteLine($"The number was: {randomNumber}");//Reveals what the random number was.
                        break;
                    }
                    Console.Write($"You have {totalTries - numOfTries} atempts left. Try another guess: ");//Tells the user to try again.
                }
                else
                {
                    Console.WriteLine("Correct!");//Tells the user they guessed correctly on the game.
                    break;
                }
            }
        }
    }
}