using System;

public class Entry
{
    // Member variables
    public string _date = DateTime.Now.ToShortDateString();
    public string _prompt = "";
    public string _response = "";
    public string _mood = "";

    // Constructor
    public Entry()
    {
        
    }

    // Method
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Mood: {_mood}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine();
    }
}