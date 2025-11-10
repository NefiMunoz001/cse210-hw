using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>()
    {
        "What made you smile today?",
        "What was something you learned today?",
        "How did you help someone today?",
        "What are you grateful for today?",
        "Describe a challenge you faced today."
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
