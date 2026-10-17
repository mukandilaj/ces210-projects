using System;
using System.IO;
using System.Collections.Generic;

public class GoalManager
{
    // Member variables
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    // Constructor
    public GoalManager()
    {
        
    }

    // Methods
    public void Start()
    {
        int choice = 0;
        while (choice != 6)
        {
            Console.Clear();
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");

            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (choice == 1)
            {
                CreateGoal();
            }
            else if (choice == 2)
            {
                ListGoalDetails();
            }
            else if (choice == 3)
            {
                SaveGoals();
            }
            else if (choice == 4)
            {
                LoadGoals();
            }
            else if (choice == 5)
            {
                RecordEvent();
            }
            if (choice != 6)
            {
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine($"Level: {GetLevel()}");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            _goals.Add(new SimpleGoal(name, description, points, false));
        }
        else if (choice == 2)
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (choice == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, points, 0, target, bonus));
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());
        Goal selectedGoal = _goals[choice - 1];
        int earnedPoints;
        selectedGoal.RecordEvent();
        if (selectedGoal is ChecklistGoal)
        {
            ChecklistGoal goal = (ChecklistGoal)selectedGoal;
            earnedPoints = goal.GetEarnedPoints();
        }
        else
        {
            earnedPoints = selectedGoal.GetPoints();
        }
        _score += earnedPoints;
        Console.WriteLine($"Congratulations! You have earned {earnedPoints} points!");
        Console.WriteLine($"You now have {_score} points.");
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        string[] lines = File.ReadAllLines(fileName);
        _goals.Clear();
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');
            string goalType = parts[0];
            string[] values = parts[1].Split(',');

            if (goalType == "SimpleGoal")
            {
                string name = values[0];
                string description = values[1];
                int points = int.Parse(values[2]);
                bool isComplete = bool.Parse(values[3]);
                _goals.Add(new SimpleGoal(name, description, points, isComplete));
            }
            else if (goalType == "EternalGoal")
            {
                string name = values[0];
                string description = values[1];
                int points = int.Parse(values[2]);
                _goals.Add(new EternalGoal(name, description, points));
            }
            else if (goalType == "ChecklistGoal")
            {
                string name = values[0];
                string description = values[1];
                int points = int.Parse(values[2]);
                int amountCompleted = int.Parse(values[3]);
                int target = int.Parse(values[4]);
                int bonus = int.Parse(values[5]);
                _goals.Add(new ChecklistGoal(name, description, points, amountCompleted, target, bonus));
            }
            
        } 
    }
    public int GetLevel()
    {
        return (_score / 1000) + 1;
    }
}