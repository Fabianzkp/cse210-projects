using System;
//I exceeded requirement by including a progress tracker to display the progress
//percentage along with the scripture verse.

namespace ScriptureApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Scripture Memorization Program!");

            // Create a ProgressTracker and a Scripture object with "Proverbs 3:5-6" verse
            ProgressTracker progressTracker = new ProgressTracker(totalWords: 50); // Adjust the totalWords based on your scripture length
            Scripture scripture = new Scripture("Proverbs 3:5-6", "Trust in the LORD with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.", progressTracker);

            Console.WriteLine("Press 'Enter' to start or type 'quit' to exit.");
            Console.ReadLine(); // Wait for the user to press Enter

            while (true)
            {
                // Display the complete scripture
                scripture.Display();

                // Hide a few words and display the updated scripture
                scripture.HideRandomWords();

                string userInput = Console.ReadLine().ToLower();

                if (userInput == "quit")
                {
                    Console.WriteLine("Goodbye!");
                    return;
                }
            }
        }
    }
}
