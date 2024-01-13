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


// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Prep3 World!");

//         Random random = new Random();
//         int magicNumber = random.Next(1, 101);

//         int guess = -1;
//         // Console.WriteLine("Guess the magic number");
//         // string num = Console.ReadLine();
//         // int number = int.Parse(num);

//         while (guess != magicNumber)
//         {
//             Console.WriteLine("You guessed the wrong number. Try again.");
//             guess = int.Parse(Console.ReadLine());

//             if (guess > magicNumber)
//             {
//                 Console.WriteLine("Guess a lower number");
//             }
//             else if (guess < magicNumber)
//             {
//                 Console.WriteLine("Guess a higher number");
//             }
//             else
//             {
//                 Console.WriteLine("Correct guess!");
//             }
//         }   

        

        
//     }
// }

