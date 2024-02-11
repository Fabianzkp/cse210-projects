using System;

namespace MindfulnessApp
{
    public abstract class MindfulnessActivity
    {
        protected int duration;

        protected abstract string GetDescription();

        protected virtual string GetEndingMessage()
        {
            return $"Good job! You have completed the {GetType().Name}. You have completed it for {duration} seconds. Returning to the main menu in 5 seconds...";
        }

        protected virtual void PerformActivityAction(string actionMessage, int seconds)
        {
            Console.WriteLine(actionMessage);
            PauseWithSpinner(seconds);
        }

        protected void PauseWithSpinner(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

        protected int GetDuration()
        {
            Console.Write("Enter the duration of the activity in seconds: ");
            while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
            {
                Console.WriteLine("Invalid duration. Please enter a positive integer.");
                Console.Write("Enter the duration of the activity in seconds: ");
            }
            return duration;
        }

        public void Start()
        {
            duration = GetDuration();
            Console.WriteLine(GetDescription());
            Console.WriteLine("Prepare to begin in 5 seconds...");
            PerformActivityAction("", 5);
            PerformActivity();
            Console.WriteLine(GetEndingMessage());
            PerformActivityAction("", 5);
        }

        protected abstract void PerformActivity();
    }
}
