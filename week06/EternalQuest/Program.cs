// Leveling system added to make the program more game-like.
// The player at level 1 and gains a new level every 1000 points earned.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}