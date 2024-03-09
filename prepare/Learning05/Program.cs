using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Circle(3, "purple"));
        shapes.Add(new Square(4, "blue"));
        shapes.Add(new Rectangle(2, 5, "white"));

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.Write($"the {color} shape has an area of {area}. ");
        }
        
    }
}