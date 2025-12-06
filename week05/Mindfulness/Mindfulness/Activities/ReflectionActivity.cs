using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you helped someone in need.",
        "Recall a moment when you overcame a challenge.",
        "Think of a time when you felt real joy."
    };

    public ReflectionActivity()
    {
        _name = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength.";
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");
        Pause(5);

        Console.WriteLine("Reflect on this...");
        Thread.Sleep(_duration * 1000);

        DisplayEndingMessage();
    }
}
