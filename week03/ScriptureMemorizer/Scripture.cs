using System.Collections.Generic;

public class Scripture
{
    // Member variables
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    // Constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(' ');
        foreach (string wordText in words)
        {
            Word word = new Word(wordText);
            _words.Add(word);
        }
    }

    // Methods
    public void HideRandomWords(int numberToHide)
    {
        
    }
    public string GetDisplayText()
    {
        
    }
    public bool IsCompletelyHidden()
    {
        
    }

}