using System;

class Program
{
    static void Main(string[] args)
    {
        List<double> list = new List<double>();
        double sum = 0;

        double input = -1;

        while (input != 0)
        {
            Console.Write("Enter Number: ");
            input = double.Parse(Console.ReadLine());
            if (input != 0)
            {
                list.Add(input);
            }
        }
        foreach (double n in list)
        {
            sum += n;
        }
        Console.WriteLine($"The total is: {sum}");
    }
}