using System;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "> Why was this experience meaningful to you?",
        "> How did you get started?",
        "> How did you feel when it was complete?",
        "> What did you learn about yourself?",
        "> What made this experience special?",
        "> What could you learn from this experience?"
    };

    Random random = new Random();

    public ReflectionActivity()
        : base(
            "Reflection",
            "This activity will help you reflect on times when you have shown strength and resilience.")
    {
    }

    private string GetRandomPrompt()
    {
        return _prompts[random.Next(_prompts.Count)];
    }

    private string GetRandomQuestion()
    {
        return _questions[random.Next(_questions.Count)];
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine(GetRandomPrompt());

        Console.WriteLine("\nThink about this...");
        ShowSpinner(5);

        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            // Console.WriteLine();
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }
}


