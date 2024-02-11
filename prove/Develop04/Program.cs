//To exceed requirement, I added a "Gratitude Activity" to help user cultivate the habit 
//of gratitude. Users will have the option to start gratitude activity after 
//completing any of the mindfulness activity. This is now option 4 in my program. 
using System;
namespace MindfulnessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Develop04 World!");
            MindfulnessApp app = new MindfulnessApp();
            app.Run();

            GratitudeActivity gratitudeActivity = new GratitudeActivity();
            gratitudeActivity.Start();
        }
    }
}
