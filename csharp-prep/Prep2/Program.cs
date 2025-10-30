using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        int gradeNumber;
        string letterGrade;
        string gradeSign = "";

        Console.Write("Please Enter Your Grade as a Number: ");
        gradeNumber = int.Parse(Console.ReadLine());

        if (gradeNumber >= 90)
        {
            letterGrade = "A";
        }
        else if (gradeNumber >= 80)
        {
            letterGrade = "B";
        }
        else if (gradeNumber >= 70)
        {
            letterGrade = "C";
        }
        else if (gradeNumber >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F"; ;
        }


        if ((gradeNumber % 10) >= 7 && gradeNumber < 90 && gradeNumber >= 60)
        {
            gradeSign = "+";
        }
        else if ((gradeNumber % 10) < 3 && gradeNumber >= 60)
        {
            gradeSign = "-";
        }
        
        Console.WriteLine($"Grade for this Class {letterGrade}{gradeSign}");

        if (gradeNumber >= 70)
        {
            Console.WriteLine("Congrats! You passed the class!");
        }
        else
        {
            Console.WriteLine("Unfortunately you did not pass the class. Better luck next time!");
        }
        
    }
}