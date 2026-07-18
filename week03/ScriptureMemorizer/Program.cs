/*
=====================================================================================
CREATIVITY AND EXCEEDING REQUIREMENTS REPORT:
I exceeded the core requirements by adding a "Hint" feature. When memorizing, a user 
might get stuck on a hidden word. Instead of forcing them to restart, the user can 
type 'hint' into the console. The program will randomly choose one of the currently 
hidden words and reveal it back to the user, making use of the Word class's Show() 
method.
=====================================================================================
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding in all thy ways acknowledge him and he shall direct thy paths";
        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            // Updated prompt to show the new Hint capability
            Console.WriteLine("Press enter to continue, type 'hint' for help, or type 'quit' to finish:");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
            {
                break;
            }
            else if (input == "hint")
            {
                // Calling the exceeding requirement behavior
                scripture.RevealRandomWord();
            }
            else
            {
                // Otherwise, proceed normally by hiding 3 words
                scripture.HideRandomWords(3);
            }
        }
    }
}