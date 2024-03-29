


public class Circle : Shape
{
    private int _radius;

    public Circle(int radius, string color) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return 3.14 * Math.Pow(_radius, 2);
    }

}