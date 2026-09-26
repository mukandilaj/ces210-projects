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
        Random randomGenerator = new Random();
        int hiddenCount = 0;
        while (hiddenCount < numberToHide)
        {
            int j = randomGenerator.Next(0, _words.Count);
            if (!_words[j].IsHidden())
            {
                _words[j].Hide();
                hiddenCount ++;
            }
            if (IsCompletelyHidden())
            {
                break;
            }
            
        }
    }
    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText();
        foreach (Word word in _words)
        {
            string displayWord = word.GetDisplayText();
            displayText += " " + displayWord;
        }
        return displayText;
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (! word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

}