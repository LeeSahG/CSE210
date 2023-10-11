using System;

class Program
{
    static void Main(string[] args)
    {
        // To create a random number, use Random class and assign
        // to variable
        int magicNumber = 5;

        // Declare variable so can be used in while loop
        int guess = -1;

        while (guess != magicNumber)
        {
            Console.WriteLine("What is your guess? ");
            
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Guess lower.");
            }

            else if (guess > magicNumber)
            {
                Console.WriteLine("Guess lower.");
            } 

            else{
                Console.WriteLine("You guess right!");
            }
        }

    }
}