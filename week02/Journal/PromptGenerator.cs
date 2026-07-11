using System.Runtime.InteropServices;
using System.Collections.Generic;
using System;

public class promptGenerator
{
    public List<string> _prompts = new List<string>();
       

    public string GetRandomPrompt()
    {
        if (_prompts.Count ==0)
        {
            _prompts.Add("Who whas the most interesting person I interacted with today? ");
            _prompts.Add("What was the best part of my day? ");
            _prompts.Add("How did I see the hand of the Lord in my life today? ");
            _prompts.Add("What was the strongest emotion I felt today? ");
            _prompts.Add("If I had one thing I could do over today, what would it be? ");
            _prompts.Add("Did I made someone feel valued today? ");
            _prompts.Add("what habit do I want to improve? ");
            _prompts.Add("How can I be Kinder with myself tomorrow? ");
            _prompts.Add("How did you hornored you callings today? ");
            _prompts.Add("How did you serve the Lord today? ");
        }

        // picking a random prompt

        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}