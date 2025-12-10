using System;
using System.IO;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private int _level = 1;  // Feature extra creativa

    public void DisplayScore()
    {
        Console.WriteLine($"\nCurrent Score: {_score} | Level {_level}\n");
    }

    public void ListGoals()
    {
        Console.WriteLine("\n--- Your Goals ---");
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals yet.");
            return;
        }

        int index = 1;
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{index}. {g.Display()}");
            index++;
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nTypes:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choose: ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            _goals.Add(new SimpleGoal(name, desc, points));
        }
        else if (choice == 2)
        {
            _goals.Add(new EternalGoal(name, desc, points));
        }
        else if (choice == 3)
        {
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, desc, points, bonus, target));
        }

        Console.WriteLine("Goal created!");
    }

    public void RecordEvent()
    {
        ListGoals();

        Console.Write("\nWhich goal did you complete? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        Goal g = _goals[index];
        g.RecordEvent();

        _score += g.GetPoints();

        if (g is ChecklistGoal ck && ck.IsComplete())
        {
            _score += ck.GetBonus();
        }

        UpdateLevel();

        Console.WriteLine("Event recorded!");
    }

    private void UpdateLevel()
    {
        _level = (_score / 100) + 1; // Feature creativa simple
    }

    public void SaveGoals()
    {
        Console.Write("File name to save: ");
        string file = Console.ReadLine();

        using (StreamWriter output = new StreamWriter(file))
        {
            output.WriteLine(_score);
            output.WriteLine(_level);
            foreach (Goal g in _goals)
            {
                output.WriteLine(g.GetStringRepresentation());
            }
        }

        Console.WriteLine("Saved!");
    }

    public void LoadGoals()
    {
        Console.Write("File name to load: ");
        string file = Console.ReadLine();

        if (!File.Exists(file))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _goals.Clear();

        string[] lines = File.ReadAllLines(file);
        _score = int.Parse(lines[0]);
        _level = int.Parse(lines[1]);

        for (int i = 2; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            string type = parts[0];
            string[] data = parts[1].Split("|");

            if (type == "SimpleGoal")
            {
                _goals.Add(new SimpleGoal(data[0], data[1],
                    int.Parse(data[2]), bool.Parse(data[3])));
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(data[0], data[1],
                    int.Parse(data[2])));
            }
            else if (type == "ChecklistGoal")
            {
                _goals.Add(new ChecklistGoal(
                    data[0], data[1], int.Parse(data[2]),
                    int.Parse(data[3]), int.Parse(data[4]),
                    int.Parse(data[5])));
            }
        }

        Console.WriteLine("Loaded!");
    }
}
