using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        while (true)
        {
            Console.Write("Please input a number (enter 0 to stop): ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                if (num == 0)
                {
                    break;
                }
                numbers.Add(num);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        // Find the smallest positive number
        int smallestPositive = numbers.Where(n => n > 0).DefaultIfEmpty(0).Min();
        Console.WriteLine($"Smallest positive number: {smallestPositive}");

        // Sort the list
        numbers.Sort();

        // Display the sorted list
        Console.WriteLine("Sorted list:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

        // Calculating and displaying the sum
        int sum = numbers.Sum();
        Console.WriteLine($"\nSum = {sum}");

        // Calculating and displaying the average
        int count = numbers.Count;
        if (count > 0)
        {
            float average = (float)sum / count;
            Console.WriteLine($"Average = {average:F1}");
        }
        else
        {
            Console.WriteLine("Please input a number to calculate average.");
        }

        // Finding and displaying the maximum
        if (count > 0)
        {
            int max = numbers.Max();
            Console.WriteLine($"Maximum number = {max}");
        }
        else
        {
            Console.WriteLine("No numbers entered to find the maximum.");
        }
    }
}


