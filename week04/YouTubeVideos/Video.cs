using System;
using System.Collections.Generic;

public class Video
{
    // Member variables
    public string _title = "";
    public string _author = "";
    public double _length = 0; // in seconds
    public List<Comment> _comments = new List<Comment>();

    // Constructor
    public Video()
    {
        
    }

    // Methods
    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length in seconds: {_length}");
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberComments()
    {
        return _comments.Count;
    }
}