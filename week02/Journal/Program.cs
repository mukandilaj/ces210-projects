using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        int number = 1;
        Journal journal = new Journal();
        while (number != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();
            number = int.Parse(choice);
            
            if (number == 1)
            {
                // Diplay random prompt
                Entry entry = new Entry();
                PromptGenerator prompt = new PromptGenerator();
                entry._prompt = prompt.GetRandomPrompt();
                Console.WriteLine(entry._prompt);
                Console.Write("> ");
                entry._response = Console.ReadLine();
                Console.Write("Mood: ");
                entry._mood = Console.ReadLine();
                journal.AddEntry(entry);
            }

            else if (number == 2)
            {
                // Display the Journal
                journal.DisplayEntries();
            }

            else if (number == 3)
            {
                // Load the Journal
                journal.LoadEntries();
            }

            else if (number == 4)
            {
                // Save the Journal
                journal.SaveEntries();
            }

            else if (number == 5)
            {
                    
            }
        }
    }
    
}

