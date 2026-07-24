using System;

public class Comment
{
    public string name;
    public string text;

    public void Display()
    {
        Console.WriteLine($"  - {name}: \"{text}\"");
    }
}