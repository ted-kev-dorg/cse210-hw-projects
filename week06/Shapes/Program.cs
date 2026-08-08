using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Shapes Project.");

        // Test Square
        Square square = new Square("Red", 4);
        Console.WriteLine($"{square.GetColor()} square area: {square.GetArea()}");

        // Test Rectangle
        Rectangle rectangle = new Rectangle("Blue", 5, 3);
        Console.WriteLine($"{rectangle.GetColor()} rectangle area: {rectangle.GetArea()}");

        // Test Circle
        Circle circle = new Circle("Green", 2);
        Console.WriteLine($"{circle.GetColor()} circle area: {circle.GetArea()}");

        // Build a list of shapes (polymorphism in action)
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}