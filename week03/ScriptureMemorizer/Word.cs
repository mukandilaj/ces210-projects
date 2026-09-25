using System;

public class Word
{
    // Member variables

    private string _text;
    private bool _isHidden = false;

    // Constructor
    public Word(string text)
    {
        _text = text;
    }

    // Methods
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        
    }
    public bool IsHidden()
    {
        
    }
    public string GetDisplayText()
    {
        
    }
}