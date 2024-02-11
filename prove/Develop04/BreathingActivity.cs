using System;

namespace MindfulnessApp
{
    public class BreathingActivity : MindfulnessActivity
    {
        protected override string GetDescription()
        {
            return "Breathing Activity\nThis activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        }

        protected override void PerformActivity()
        {
            for (int i = 0; i < duration; i += 2)
            {
                PerformActivityAction("Breathe in...", 2);
                PerformActivityAction("Breathe out...", 2);
            }
        }
    }
}
