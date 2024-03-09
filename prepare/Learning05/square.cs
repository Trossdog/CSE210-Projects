

public class Square : Shape
{
    private int _side;   
    public Square(int side, string color) : base(color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}