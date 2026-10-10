// No random prompts/questions are selected until they have all been used at least once in that session.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        ListingActivity listingActivity = new ListingActivity();
        int number = 0;
        while (number != 4)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            number = int.Parse(Console.ReadLine());

            if (number == 1)
            {
               breathingActivity.Run(); 
            }
            else if (number == 2)
            {
                reflectingActivity.Run();
            }
            else if (number == 3)
            {
                listingActivity.Run();
            }
            else if (number == 4)
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}