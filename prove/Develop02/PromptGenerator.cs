using System;
using System.Collections.Generic;

class PromptGenerator
{
    List<string> prompts = new List<string>()
    {
        "What was the best part of your day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
    };

    Random random = new Random();
    int randomIndex;

    public PromptGenerator()
    {
        randomIndex = random.Next(prompts.Count);
    }

    public string GetRandomPrompt()
    {
        return prompts[randomIndex];
    }
}