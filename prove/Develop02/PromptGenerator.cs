using System;
using System.Collections.Generic;

class PromptGenerator
{
    private Random random = new Random();

    public string GetRandomPrompt()
    {
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What has been your best moment today?",
            "What exercises will you do this week?",
            "What would you get from the market today?",
        };

        int randomIndex = random.Next(prompts.Count);
        return prompts[randomIndex];
    }
}
