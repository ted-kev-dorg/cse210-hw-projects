using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);


        static void DisplayWelcome ()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string fullName = Console.ReadLine();
            return fullName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int favoriteNumber = int.Parse(Console.ReadLine());
            return favoriteNumber;
        }

        static int SquareNumber(int userNumber)
        {
            int square = userNumber*userNumber;
            return square;
        }

        static void DisplayResult ( string userFullName, int userFavoriteNumber)
        {
            Console.WriteLine($"{userFullName}, the square of your number is {userFavoriteNumber}");
        }



    }
}