using System;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Let's come up with a radom number f between 1 and 1000
            var r = new Random();
            int favNumber = r.Next(1, 500);

            // Invite the user to guess it
            int userGuess = 0;
            int numAttempts = 0;
            do 
            {
                Console.WriteLine("Guess my number (1 to 500)...");
                userGuess = int.Parse(Console.ReadLine());
                ++numAttempts;
                if (userGuess < favNumber)
                {
                    Console.WriteLine("Too low");
                }
                else if (userGuess > favNumber)
                {
                    Console.WriteLine("Too high");
                }
            } while (userGuess != favNumber);
            Console.WriteLine($"Congratulations on a correct guess. You escaped the endless loop in {numAttempts} tries!");
        }
    }
}
