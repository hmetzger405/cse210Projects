using System;

class Program
{
    static void TestValues(int x, float y, double z)
    {
        Console.WriteLine($"The values are: {x}, {y}, {z}");
    }

    static int AddValues(int n1, int n2, int n3)
    {
        int total = n1 + n2 + n3;
        return total;
    }
    static void Main(string[] args)
    {
        TestValues(10, (float)123.321, 123.32432432423424);

        int total = AddValues(10, 20, 30);
        Console.WriteLine($"The total is {total}");
        /*Console.WriteLine("Hello Sandbox World!");
        string firstName;
        string lastName;

        Console.Write("Please enter your first name: ");
        firstName = Console.ReadLine(); 
        
        Console.Write("Please enter your last name: ");
        lastName = Console.ReadLine();

        Console.WriteLine($"Your name is: {lastName}, {firstName} {lastName}"); 

        Console.WriteLine(Math.Pow(2, 10));

        int x = 10;
        Console.WriteLine($"{x}, {++x}, {x++}, {x}");

        for (int i = -1000; i <= 1000; i++)
        {
            Console.WriteLine(i * 10);
        } 

        bool done = false;

        while (!done)
        {
            Console.Write("Please Input Your Age: ");
            int age = int.Parse(Console.ReadLine());
            if (age >= 0 && age <= 125)
            {
                done = true;
                Console.WriteLine($"Super age: {age}");
            }
        }

        done = false;
        do
        {
            Console.Write("Please Input Your Age: ");
            int age = int.Parse(Console.ReadLine());
            if (age >= 0 && age <= 125)
            {
                done = true;
                Console.WriteLine($"Super age: {age}");
            }
        } while(!done); 

        List<int> numbers = new List<int>();
        numbers.Add(10);
        numbers.Add(435);
        numbers.Add(432);

        foreach(int n in numbers)
        {
            Console.WriteLine($"The number is {n}");
        }
        */
    }
}