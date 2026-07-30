using System;

public class Comment
{
    // Member variables updated to use _underscoreCamelCase
    public string _name;
    public string _text;

    public void Display()
    {
        Console.WriteLine($"  - {_name}: \"{_text}\"");
    }
}