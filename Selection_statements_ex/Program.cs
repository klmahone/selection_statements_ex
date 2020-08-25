using System;

namespace Selection_statements_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Number Guessing Game");
            Console.WriteLine("I am thinking of a number can you guess it?");
            Console.WriteLine("You choose the range of numbers that we use ... \n" +
                "What is your upper limit for the range of the numbers?");

            var userResponse = Console.ReadLine();

            var upperLimit = int.Parse(userResponse);

            var random = new Random();
            var number = random.Next(1, upperLimit);

            int guess;
            do
            {
                Console.WriteLine("put in your guess:");

                guess = int.Parse(Console.ReadLine());

                if (guess > number)
                {
                    Console.WriteLine("Your guess it too high! Sorry try again.");
                }
                else if (guess < number)
                {
                    Console.WriteLine("your guess is too low! Sorry try again.");
                }
                else
                {
                    Console.WriteLine("BooYah!");
                }
            } while (guess != number);
        }
    }
}


