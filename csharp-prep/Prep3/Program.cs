using System;
using System.Net;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random rng = new Random();

        int again = 1;
        while (again != 0)
        {
            int guess;
            int magicNumber = rng.Next(1, 101);
            int count = 0;

            do
            {
                Console.Write("What is your guess?: ");
                guess = int.Parse(Console.ReadLine());


                if (magicNumber == guess)
                {
                    Console.WriteLine("Correct!");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("Higher");
                }
                count++;
            } while (guess != magicNumber);

            Console.WriteLine($"You guessed {count} times");
            Console.Write("Type [1] to Continue, and [0] to exit: ");
            again = int.Parse(Console.ReadLine());
        }
    }
}