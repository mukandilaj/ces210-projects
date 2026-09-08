using System. Collections. Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = 1;
        int sum = 0;
        float average = 0;
        int max = 1;
        while (number != 0)
        {
            Console.Write("Enter number: ");
            string num = Console.ReadLine();
            number = int.Parse(num);
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        
        for (int i = 0; i < numbers.Count; i ++)
        {
            sum = sum + numbers[i];
            average = sum / numbers.Count;
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        
    }
}