using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    // Member variables
    public List<Entry> _entries = new List<Entry>();

    // Constructor
    public Journal()
    {
        
    }

    // Method
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveEntries()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date} | {entry._mood} | {entry._prompt} | {entry._response}");
            }
        }
    }
    public void LoadEntries()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        _entries = new List<Entry>();
        string[] lines = System.IO.File.ReadAllLines (filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            string date = parts[0].Trim();
            string mood = parts[1].Trim();
            string prompt = parts[2].Trim();
            string response = parts[3].Trim();
            Entry entry = new Entry();
            entry._date = date;
            entry._mood = mood;
            entry._prompt = prompt;
            entry._response = response;
            _entries.Add(entry);
        }
            
            
    }
}
