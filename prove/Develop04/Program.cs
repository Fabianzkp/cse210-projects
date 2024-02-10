using System;
using MathsApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        Assignment assignment = new Assignment("Anana", "Fraction");
        string summary = assignment.GetSummary();
        Console.WriteLine(summary);

        MathAssignment mathAssignment = new MathAssignment("Anana Agwu", "Fraction", "7.3", "8-19");
        string homework = mathAssignment.GetHomeworkList();
        Console.WriteLine(homework);

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
        
    }
}