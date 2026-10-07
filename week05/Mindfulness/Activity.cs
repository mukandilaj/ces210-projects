using System;

public class Activity
{
    // Member variables
    private string _name;
    private string _description;
    private int _duration;

    // Constructor
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    // Getters
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetDuration()
    {
        return _duration;
    }

    // Methods
    public void DisplayStartingMessage()
    {
        
    }
    public void DisplayEndingMessage()
    {
        
    }
    public void ShowSpinner(int seconds)
    {
        
    }
    public void ShowCountDown(int seconds)
    {
        
    }
}