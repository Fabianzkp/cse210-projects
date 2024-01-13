using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        // Call the DisplayMessage method
        DisplayMessage();
        string userName = PromptUserName();
        int favoriteNumber = PromptFavoriteNumber();

        // Calculate the squared number
        int squaredNumber = SquaredNumber(favoriteNumber);

        // Display the result
        DisplayResult(userName, squaredNumber);
    }

    // Define the DisplayMessage method outside of the Main method
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello {name}");
        return name;
    }

    static int PromptFavoriteNumber()
    {
        Console.WriteLine("What is your favorite number?");
        return int.Parse(Console.ReadLine());
    }

    // Modify SquaredNumber to take an integer parameter and return the squared result
    static int SquaredNumber(int number)
    {
        int squared = number * number;
        return squared;
    }

    // Define DisplayResult to accept the user's name and squared number and display them
    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"Hello {userName}! Your favorite number squared is: {squaredNumber}");
    }
}
