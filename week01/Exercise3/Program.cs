using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next (1,100);

        // Console.Write("What is the magic number? ");
        // string choice = Console.ReadLine();
        // int magicNumber = int.Parse(choice);
       

        int guessNumber =-1;
        int NumberOfGuess = 0;

        while (magicNumber != guessNumber)
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            guessNumber = int.Parse(guess);
            NumberOfGuess= NumberOfGuess + 1;

            if (magicNumber > guessNumber)
            {
                Console.WriteLine("Higher");
            }

            else if  (magicNumber < guessNumber)
            {
                Console.WriteLine("Lower");
            }
            
        }        
        
        Console.WriteLine("You guessed it!");
        Console.WriteLine($"You got it in {NumberOfGuess} guesses!");
        

        
    }
}