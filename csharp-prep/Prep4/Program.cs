using System;

class Program
{
    static void Main(string[] args)
    {
        List<double> list = new List<double>();
        double sum = 0;
        double avg = 0;
        double max = 0;

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

        avg = (sum / list.Count);

        foreach (double n in list)
        {
            if (n > max)
            {
                max = n;
            }
        }

        Console.WriteLine($"The total is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is {max}");
    }
}