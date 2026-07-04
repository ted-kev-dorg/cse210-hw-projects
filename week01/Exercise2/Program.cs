using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise2 Project.");
        string letter = "";
        Console.Write("What is your score? ");
        string score = Console.ReadLine();

        if (int.Parse(score) >= 90)
        {
            letter ="A";
            
        }

        else if (int.Parse(score) >= 80)
        {
            letter ="B";
           
        }

        else if (int.Parse(score) >= 70)
        {
            letter = "C";
            
        }

        else if (int.Parse(score) >= 60)
        {
            letter = "D";
            
        }

        else
        {
            letter ="F";
            
        }

        Console.WriteLine($"Your grade is {letter}");

        if (int.Parse(score) >= 70)
        {
            Console.WriteLine("Congratulation! you have passed the exam");
        }

        else
        {
            Console.WriteLine ("Sorry, you have failed! Try again.");
        }



    }
}