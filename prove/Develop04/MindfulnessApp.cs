using System;

namespace MindfulnessApp
{
    public class MindfulnessApp
    {
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Welcome to the Mindfulness App");
                Console.WriteLine("1. Start Breathing Activity");
                Console.WriteLine("2. Start Reflection Activity");
                Console.WriteLine("3. Start Listing Activity");
                Console.WriteLine("4. Start Gratitude Activity");
                Console.WriteLine("5. Quit");

                Console.Write("Select a choice from the menu: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        new BreathingActivity().Start();
                        break;
                    case "2":
                        new ReflectionActivity().Start();
                        break;
                    case "3":
                        new ListingActivity().Start();
                        break;
                    case "4":
                        new GratitudeActivity().Start();
                        break;
                    case "5":
                        Console.WriteLine("Thank you for using the Mindfulness App. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
