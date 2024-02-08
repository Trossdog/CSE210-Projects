

class Fraction
{
    private int _top;
    private int _bottom;
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholenumber)
    {
        _top = wholenumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
        {
            string result = $"{_top}/{_bottom}";
            return result;
        }

    public double GetDecimalValue(int top, int bottom)
    {
        double result;
        result = (top/bottom);
        return result;
    }


}