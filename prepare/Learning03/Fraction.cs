/*****************************
FRACTION class
******************************/

Class Fraction 
{
    // Setting the fraction attributes
    private int _top;
    private int _bottom;

    public Fraction()
    {
        int _top = 1;
        int _bottom = 2;
    }

    public Fraction(int integer)
    {
        int _top = integer;
        int _bottom = 1;
    }

    public Fraction(int integerTop, int integerBottom)
    {
        int _top = integerTop;
        int _bottom = integerBottom;
    }

    public string GetFractionString()
    {
        string fraction = ($"{_top}/{_bottom}");
        return fraction;
    }

    public double Get Decimal()
    {
        return _top / _bottom;
    }
}