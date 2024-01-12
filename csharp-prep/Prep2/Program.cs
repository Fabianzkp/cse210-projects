using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage?");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letter;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >=80)
        {
            letter = "B";
        }
        else if (grade >=70)
        {
            letter = "C";
        }
        else if (grade >=60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        if  (grade %10 >=7 && grade>=90)
        {
            letter = "A";
        }
        else if (grade %10 <3 && grade>=90)
        {
            letter += "-";
        }
        else if (grade %10 >=7 && grade>=80)
        {
            letter += "+";
        }
        else if (grade %10 <3 && grade>=80)
        {
            letter += "-";
        }
        else if (grade %10 >=7 && grade>=70)
        {
            letter += "+";
        }
        else if (grade %10 <3 && grade>=70)
        {
            letter += "-";
        }
        else if (grade %10 >=7 && grade>=60)
        {
            letter += "+";
        }
        else if (grade %10 <3 && grade>=60)
        {
            letter += "-";
        }
        
        Console.WriteLine($"{letter}");
        if (grade >=70)
        {
            Console.WriteLine("Congratulation's, you passed the course!");
        }
        else
        {
            Console.WriteLine("Try harder next time. I know you can do it.");
        }
    }
}