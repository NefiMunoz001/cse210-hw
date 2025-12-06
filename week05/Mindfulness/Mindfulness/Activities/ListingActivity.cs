using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "List people who you appreciate.",
        "List your personal strengths.",
        "List moments when you felt peaceful."
    };

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you list positive aspects of your life.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = _prompts[new Random().Next(_prompts.Count)];
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("Start listing items:");

        List<string> items = new List<string>();

        DateTime end = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < end)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"You listed {items.Count} items.");

        DisplayEndingMessage();
    }
}
