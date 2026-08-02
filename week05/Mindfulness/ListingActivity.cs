using System;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are your personal strengths?",
        "Who have you helped this week?",
        "Who are your personal heroes?"
    };

    Random random = new Random();

    public ListingActivity()
        : base(
            "Listing",
            "This activity will help you reflect on the good things in your life.")
    {
    }

    private string GetRandomPrompt()
    {
        return _prompts[random.Next(_prompts.Count)];
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine(GetRandomPrompt());

        Console.WriteLine("\nBegin in...");
        ShowCountDown(5);

        List<string> items = new List<string>();

        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");

        DisplayEndingMessage();
    }
}


