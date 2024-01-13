using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random random = new Random();
        int magicNumber = random.Next(1, 101);

        int guess = -1;
        
        while (guess != magicNumber)
        {
            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicNumber)
            {
                Console.WriteLine("Guess a lower number");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Guess a higher number");
            }
            else
            {
                Console.WriteLine("Correct guess!");
            }
        }
    }
}


