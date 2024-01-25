using System;
using System.Collections.Generic;
using System.IO;

class JournalApp
{
    private static List<Entry> entries = new List<Entry>();
    private static Random random = new Random();
    private static PromptGenerator promptGenerator = new PromptGenerator();

    public static void Run()
    {
        while (true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            int choice = GetIntInput("Enter your choice: ");

            switch (choice)
            {
                case 1:
                    WriteNewEntry();
                    break;
                case 2:
                    DisplayJournal();
                    break;
                case 3:
                    SaveJournalToFile();
                    break;
                case 4:
                    LoadJournalFromFile();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private static void WriteNewEntry()
    {
        string prompt = promptGenerator.GetRandomPrompt();
        string response = GetStringInput($"Prompt: {prompt}\nEnter your response: ");
        string additionalInfo = GetStringInput("Enter additional information: ");
        DateTime date = DateTime.Now;

        Entry entry = new Entry(prompt, response, date, additionalInfo);
        entries.Add(entry);

        Console.WriteLine("Entry added successfully!\n");
    }

    private static void DisplayJournal()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("Journal is empty.\n");
            return;
        }

        Console.WriteLine("Journal Entries:\n");
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}, Prompt: {entry.Prompt}\nResponse: {entry.Response}\nAdditional Info: {entry.AdditionalInfo}\n");
        }
    }

    private static void SaveJournalToFile()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("Cannot save an empty journal.\n");
            return;
        }

        string fileName = GetStringInput("Enter the filename to save the journal: ");
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var entry in entries)
                {
                    writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response},{entry.AdditionalInfo}");
                }
            }

            Console.WriteLine("Journal saved successfully!\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving the journal: {ex.Message}\n");
        }
    }

    private static void LoadJournalFromFile()
    {
        string fileName = GetStringInput("Enter the filename to load the journal from: ");
        try
        {
            List<Entry> loadedEntries = new List<Entry>();

            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string[] entryParts = reader.ReadLine().Split(',');

                    if (entryParts.Length == 4 &&
                        DateTime.TryParse(entryParts[0], out DateTime date) &&
                        !string.IsNullOrWhiteSpace(entryParts[1]) &&
                        !string.IsNullOrWhiteSpace(entryParts[2]) &&
                        !string.IsNullOrWhiteSpace(entryParts[3]))
                    {
                        Entry loadedEntry = new Entry(date, entryParts[1], entryParts[2], entryParts[3]);
                        loadedEntries.Add(loadedEntry);
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry found in the file. Skipping.\n");
                    }
                }
            }

            entries = loadedEntries;
            Console.WriteLine("Journal loaded successfully!\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading the journal: {ex.Message}\n");
        }
    }

    private static string GetStringInput(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }

    private static int GetIntInput(string prompt)
    {
        Console.Write(prompt);
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                return result;
            }
            else
            {
                Console.Write("Invalid input. Please enter a valid integer: ");
            }
        }
    }
}
