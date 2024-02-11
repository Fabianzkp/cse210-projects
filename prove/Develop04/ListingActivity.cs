using System;

namespace MindfulnessApp
{
    public class ListingActivity : MindfulnessActivity
    {
        protected override string GetDescription()
        {
            return "Listing Activity\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        }

        protected override void PerformActivity()
        {
            string[] prompts = {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Mention people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };

            Random rand = new Random();
            int itemCount = 0;

            for (int i = 0; i < duration; i += 5)
            {
                int index = rand.Next(prompts.Length);
                Console.WriteLine(prompts[index]);

                Console.WriteLine("You have 10 seconds to list items...");
                PerformActivityAction("", 10);

                Console.WriteLine("Enter each item on a new line. Press Enter twice to finish.");

                string input;
                do
                {
                    input = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(input))
                        itemCount++;
                } while (!string.IsNullOrWhiteSpace(input));

                Console.WriteLine($"Number of items listed: {itemCount}");
                itemCount = 0;
            }
        }
    }
}
