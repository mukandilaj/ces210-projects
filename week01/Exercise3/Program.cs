using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";
        while (response == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);
            int guessNumber = 0;
            int count = 0;
            
            
            while (guessNumber != magicNumber)
            {
                Console.Write("What is your guess number? ");
                string guess = Console.ReadLine();
                guessNumber = int.Parse(guess);
                    
                if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }               
                else if (guessNumber > magicNumber )
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
                count ++;
            }
            Console.WriteLine($"Number of guesses: {count}");
            Console.WriteLine("Do you want to continue? ");
            response = Console.ReadLine();
        }  
        
    }
}