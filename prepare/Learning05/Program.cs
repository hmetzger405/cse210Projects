using System;

class Program
{
    static void Main(string[] args)
    {
        Square mySquare = new Square("green", 10.0);

        Console.WriteLine(mySquare.GetColor());
        Console.WriteLine(mySquare.GetArea());

        Rectangle myRectangle = new Rectangle("red", 10.0, 20.0);

        Console.WriteLine(myRectangle.GetColor());
        Console.WriteLine(myRectangle.GetArea());

        Circle myCircle = new Circle("blue", 4.0);

        Console.WriteLine(myCircle.GetColor());
        Console.WriteLine(myCircle.GetArea());


    }
}