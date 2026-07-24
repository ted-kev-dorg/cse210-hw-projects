using System;
using System.Collections.Generic;

public class Video
{
    public string title;
    public string author;
    public int lengthInSeconds;
    public List<Comment> comments = new List<Comment>();

    public int GetCommentCount()
    {
        return comments.Count;
    }

    public void Display()
    {
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Length: {lengthInSeconds} seconds");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");

        foreach (Comment comment in comments)
        {
            comment.Display();
        }
        Console.WriteLine();
    }
}