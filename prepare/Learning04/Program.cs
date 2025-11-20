using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Holden", "Math");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment myMathAssignment = new MathAssignment("Section 4.6", "Problems 1-34", "Drake", "Linear Algebra");
        Console.WriteLine(myMathAssignment.GetSummary());
        Console.WriteLine(myMathAssignment.GetHomeWorkList());
    }
}