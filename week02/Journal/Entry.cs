using System;

public class Entry
{
    // Member variables
    public string _date = DateTime.Now.ToShortDateString();
    public string _prompt = "";
    public string _response = "";

    // Constructor
    public Entry()
    {
        
    }

    // Method
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine($"{_response}");
        Console.WriteLine();
    }
}