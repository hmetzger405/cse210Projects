using System;
using System.Security.Cryptography;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name?: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number?: ");
        return int.Parse(Console.ReadLine());
    }

    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Input Your Birth Year: ");
        birthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        int value = (number * number);
        return value;
    }

    static void DisplayResult(string name, int number, int year)
    {
        int age = 2025 - year; 

        Console.WriteLine($"{name}, the square of your number is {number}");
        Console.WriteLine($"You will turn {age} this year.");
    }

    static void Main(string[] args)
    {
        int year = 0;
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        PromptUserBirthYear(out year);
        int squared = SquareNumber(number);
        DisplayResult(name, squared, year);
    }
}