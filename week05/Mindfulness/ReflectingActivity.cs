using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    // Member variables
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    private List<string> _availablePrompts = new List<string>();
    private List<string> _availableQuestions = new List<string>();
    private Random _random = new Random();

    // Constructor
    public ReflectingActivity()
        : base(
            "Reflecting Activity",
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
            0)
    { 
        _prompts.Add("Think of a time when you stood up for someone else. ");
        _prompts.Add("Think of a time when you did something really difficult. ");
        _prompts.Add("Think of a time when you helped someone in need. ");
        _prompts.Add("Think of a time when you did something truly selfless. ");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    // Methods
    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
            ShowSpinner(4);
            Console.WriteLine();
        }
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        if (_availablePrompts.Count == 0)
        {
            _availablePrompts = new List<string>(_prompts);
        }
        int index = _random.Next(0, _availablePrompts.Count);
        string prompt = _availablePrompts[index];
        _availablePrompts.RemoveAt(index);
        return prompt;
    }
    public string GetRandomQuestion()
    {
        if (_availableQuestions.Count == 0)
        {
            _availableQuestions = new List<string>(_questions);
        }
        int index = _random.Next(0, _availableQuestions.Count);
        string question = _availableQuestions[index];
        _availableQuestions.RemoveAt(index);
        return question;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue. ");
        Console.ReadLine();
        Console.WriteLine();
    }
    public void DisplayQuestion()
    {
        Console.Write($"> {GetRandomQuestion()} ");
    }
}