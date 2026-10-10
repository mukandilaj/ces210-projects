using System;

public class BreathingActivity : Activity
{
    // Constructor
    public BreathingActivity()
        : base(
            "Breathing Activity",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.",
            0)
    {

    }

    // Method
    public void Run()
    {
        DisplayStartingMessage();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(5);
            Console.Write("Now breathe out... ");
            ShowCountDown(5);
            Console.WriteLine();
        }
        DisplayEndingMessage();
    }
}