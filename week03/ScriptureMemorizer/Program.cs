// The program work with a library of scriptures rather than a single one. Choose scriptures at random to present to the user.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        List<Scripture> scriptures = new List<Scripture>();

        scriptures.Add(
            new Scripture(
                new Reference("John", 1, 1),
                "In the beginning was the Word, and the Word was with God, and the Word was God."
            )
        );

        scriptures.Add(
            new Scripture(
                new Reference("Isaiah", 1, 18),
                "Come now, and let us reason together, saith the Lord: though your sins be as scarlet, they shall be as white as snow; though they be red like crimson, they shall be as wool."
            )
        );

        scriptures.Add(
            new Scripture(
                new Reference("2 Nephi", 2, 25),
                "Adam fell that men might be; and men are, that they might have joy."
            )
        );

        scriptures.Add(
            new Scripture(
                new Reference("Doctrine and Convenants", 18, 10),
                "Remember the worth of souls is great in the sight of God;"
            )
        );

        Random randomGenerator = new Random();
        int index = randomGenerator.Next(scriptures.Count);
        Scripture scripture = scriptures[index];
        
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            string response = Console.ReadLine();
            if (response.ToLower() == "quit")
            {
                break;
            }
            scripture.HideRandomWords(3);
        }
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("All words are hidden!");

    }
}