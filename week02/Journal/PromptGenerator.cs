
using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts;
    private Random _random;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What was the best part of my day?",
            "Who made me smile today?",
            "How did I see the hand of the Lord in my life today?",
            "What is one thing I learned today?",
            "What am I grateful for today?",
            "What challenge did I overcome today?",
            "What made me happy today?",
            "What would I like to improve tomorrow?",
            "What kind thing did I do for someone today?",
            "What is one blessing I received today?"
        };

        _random = new Random();
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);

        return _prompts[index];
    }
}
