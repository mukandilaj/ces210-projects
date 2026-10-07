using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    // Member variables
    private int _count;
    private List<string> _prompts = new List<string>();

    // Constructor
    public ListingActivity()
        : base(
            "Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 
            0)
    {
        
    }

    // Methods
    public void Run()
    {
        
    }
    public void GetRandomPrompt()
    {
        
    }
    public List<string> GetListFromUser()
    {
        return new List<string>();
    }
}