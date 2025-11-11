class Program
{
    static void Main()
    {
        Circle myCircle = new Circle();

        // myCircle._radius = 10;
        myCircle.SetRadius(10);

        Console.WriteLine(myCircle.GetCircleArea());

        Circle newCircle = new Circle(10);
        Console.WriteLine(newCircle.GetCircleArea());
        
    }
}