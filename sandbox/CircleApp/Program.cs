class Program
{
    static void Main()
    {
        Console.WriteLine("Hola a todo el mundo");
        Circle myCircle = new Circle();

        // myCircle._radius = 10;
        myCircle.SetRadius(10);

        Console.WriteLine(myCircle.GetCircleArea());

        Circle newCircle = new Circle(10);
        Console.WriteLine(newCircle.GetCircleArea());
        
    }
}