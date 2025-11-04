using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        int guess;
        Console.Write("What is the magic number?: ");
        int magicNumber = int.Parse(Console.ReadLine());

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