using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        List<Activity> activities = new List<Activity>();
        Running running1 = new(new DateTime(2026, 10, 15), 30, 2);
        Cycling cycling1 = new(new DateTime(2026, 10, 15), 45, 5);
        Swimming swimming1 = new(new DateTime(2026, 10, 15), 20, 1);
        activities.Add(running1);
        activities.Add(cycling1);
        activities.Add(swimming1);
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}