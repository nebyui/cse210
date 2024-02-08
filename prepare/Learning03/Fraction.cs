class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int numerator)
    {
        _top = numerator;
        _bottom = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _top = numerator;
        _bottom = denominator;
    }

    public string GetFractionString()
    {
        string fullFraction = $"{_top}/{_bottom}";
        return fullFraction;
    }

    public double GetDecimalValue()
    {
        double quotient = (double)_top / _bottom;
        return quotient;
    }
}