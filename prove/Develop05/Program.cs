//To show creativity, I included a motivational message to be displayed. 

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int score = 0;

    static void Main(string[] args)
    {
        DisplayMotivationalMessage(); // Display a motivational message

        LoadData(); // Load saved data if any

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\nEternal Quest Menu:");
            Console.WriteLine("1. View Goals");
            Console.WriteLine("2. Create New Goal");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. View Score");
            Console.WriteLine("5. Save and Exit");
            Console.Write("Select an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    ViewGoals();
                    break;
                case "2":
                    CreateGoal();
                    break;
                case "3":
                    RecordEvent();
                    break;
                case "4":
                    Console.WriteLine($"Your current score is: {score}");
                    break;
                case "5":
                    SaveData(); // Save data before exiting
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void DisplayMotivationalMessage()
    {
        Console.WriteLine("Welcome to Eternal Quest!");
        Console.WriteLine("Embark on your journey towards self-improvement and growth.");
        Console.WriteLine("Remember, every step you take brings you closer to your goals!");
    }

    static void ViewGoals()
    {
        Console.WriteLine("\nYour Goals:");
        foreach (var goal in goals)
        {
            Console.WriteLine($"{goal.GetProgress()} {goal.GetName()}");
        }
    }

    static void CreateGoal()
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        Console.Write("Enter value for the goal: ");
        int value = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                goals.Add(new SimpleGoal(name, value));
                break;
            case "2":
                goals.Add(new EternalGoal(name, value));
                break;
            case "3":
                Console.Write("Enter target count for the checklist: ");
                int targetCount = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, value, targetCount));
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    static void RecordEvent()
    {
        Console.WriteLine("\nSelect the goal you want to record an event for:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetName()}");
        }
        Console.Write("Enter goal number: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < goals.Count)
        {
            goals[index].RecordEvent();
            score += goals[index].GetValue();
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    static void SaveData()
    {
        try
        {
            string jsonString = JsonSerializer.Serialize(goals);
            File.WriteAllText("data.json", jsonString);
            Console.WriteLine("Data saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error saving data: " + ex.Message);
        }
    }

    static void LoadData()
    {
        try
        {
            if (File.Exists("data.json"))
            {
                string jsonString = File.ReadAllText("data.json");
                goals = JsonSerializer.Deserialize<List<Goal>>(jsonString);
                if (goals == null)
                {
                    goals = new List<Goal>();
                    Console.WriteLine("No goals found in the file.");
                }
                else
                {
                    Console.WriteLine("Data loaded successfully.");
                }
            }
            else
            {
                Console.WriteLine("No saved data found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading data: " + ex.Message);
        }
    }
}
