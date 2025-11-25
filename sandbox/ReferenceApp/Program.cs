class Program
{
    static void PassReferenceType(int[] data)
    {
        data[3] = 12345;
        Console.WriteLine($"In the RT function, data[3] is {data[3]}");
    }
    static void PassByOut(out int a)
    {
        a = 17;
        Console.WriteLine($"In the function, a is: {a}");
    }
    static void PassByReference(ref int x)
    {
        x = 999;
        Console.WriteLine($"In the function, x is: {x}");
    }

    static void PassByValue(int x)
    {
        x = 1001;
        Console.WriteLine($"In the function, x is: {x}");
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello Bob");

        int x = 10;
        int y = x;
        y++;
        Console.WriteLine($"{x} {y}");

        int[] a = {1, 2, 3, 4, 5};
        int[] b = a;

        b[3] = 111;

        Console.WriteLine($"{a[3]} {b[3]}");

        PassByValue(x);
        Console.WriteLine($"In main, x is {x}");

        PassByReference(ref x);
        Console.WriteLine($"In main, x is {x}");

        int z;
        PassByOut(out z);
        Console.WriteLine($"In main, z is {z}");

        PassReferenceType(a);
        foreach(int i in a)
        {
            Console.WriteLine($"In main, i is {i}");
        }
    }
}