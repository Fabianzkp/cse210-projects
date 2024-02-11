using System;

namespace MindfulnessApp
{
    public class GratitudeActivity : MindfulnessActivity
    {
        protected override string GetDescription()
        {
            return "Gratitude Activity\nThis activity will help you cultivate gratitude by reflecting on things you are thankful for in your life.";
        }

        protected override void PerformActivity()
        {
            string[] prompts = {
                "Think of a person in your life whom you are grateful for and why.",
                "Reflect on an experience from the past week that you are grateful for.",
                "Consider a challenge you faced recently and find something positive or a lesson learned from it.",
                "Reflect on a quality or trait in yourself that you are grateful for and how it has benefited you.",
                "Think about something in nature that you are grateful for and why it brings you joy.",
                "Consider a material possession that you are grateful for and its significance in your life.",
                "Reflect on a moment of kindness or generosity you received from someone and its impact on you.",
                "Think about a place or space that brings you peace and gratitude.",
                "Consider a skill or talent you possess that you are grateful for and how it enriches your life."
            };

            Random rand = new Random();

            for (int i = 0; i < duration; i += 5)
            {
                int index = rand.Next(prompts.Length);
                Console.WriteLine(prompts[index]);

                string[] questions = {
                    "Why does this person/experience/quality/etc. make you feel grateful?",
                    "How has this aspect of your life positively influenced you or your well-being?",
                    "What lessons or insights have you gained from reflecting on gratitude?",
                    "How can you express your gratitude or appreciation for this aspect of your life?"
                };

                foreach (string question in questions)
                {
                    PerformActivityAction(question, 3);
                }
            }
        }
    }
}
