using System;
using System.Collections.Generic;

public class ReflectingActivity: Activity
{
    // Member variables
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    // Constructor
    public ReflectingActivity()
        : base(
            "Reflecting Activity",
            "This activity will help you reflect on times in your life when you have shown strengthand resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
            0)
    {
        
    }

    // Methods
    public void Run()
    {
        
    }
    public string GetRandomPrompt()
    {
        return "";
    }
    public string GetRandomQuestion()
    {
        return "";
    }
    public void DisplayPrompt()
    {
        
    }
    public void DisplayQuestion()
    {
        
    }
}