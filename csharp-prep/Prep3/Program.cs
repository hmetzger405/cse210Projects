using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random rng = new Random();

        int guess;
        int magicNumber = rng.Next(1, 101);

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
        } while (guess != magicNumber);
    }
}