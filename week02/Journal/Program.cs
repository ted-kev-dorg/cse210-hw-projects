using System;
using System.IO.Compression;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Journal Project.");

        Journal myJournal = new Journal();
        promptGenerator promptGen = new promptGenerator();
        string userChoice ="";

        Console.WriteLine("Welcome to the journal Program");

        while (userChoice != "5")
        {
            Console.WriteLine("\nPlease select on of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine($"\n Prompt: {prompt}");
                Console.Write(">");
                string response = Console.ReadLine();

                Console.Write("How are ou feeling right now? (e.g., happy , Stressed): ");
                string mood = Console.ReadLine();

                string dateText = DateTime.Now.ToShortDateString();

                //create an empty entry object
                Entry newEntry = new Entry();
                newEntry._date = dateText;
                newEntry._promptText= prompt;
                newEntry._entryText = response;
                newEntry._mood = mood;

                myJournal.AddEntry(newEntry);

            }

            else if (userChoice == "2")
            {
                Console.WriteLine ("\n---Journal Entries ---");
                myJournal.DisplayAll();
            }

            else if (userChoice == "3")
            {
                Console.Write("What is the file's name? ");
                string fileName = Console.ReadLine();
                myJournal.LoadFromFile(fileName);
            }

            else if (userChoice == "4")
            {
                Console.Write("Enter the file name: ");
                string fileName = Console.ReadLine();
                myJournal.SaveToFile(fileName);
            }
            else if (userChoice == "5")
            {
                Console.WriteLine();
                Console.WriteLine("Thank you for using the journal Program. Goodbye!");
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid option. Please enter a number from 1 to 5.");
            }
        }

    }
}