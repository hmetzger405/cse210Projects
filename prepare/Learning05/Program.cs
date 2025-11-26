using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square mySquare = new Square("Green", 10.0);
        Rectangle myRectangle = new Rectangle("Red", 5.0, 3.0);
        Circle myCircle = new Circle("Blue", 5.0);

        shapes.Add(myCircle);
        shapes.Add(myRectangle);
        shapes.Add(mySquare);

        foreach(Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
            
        }
    }
}