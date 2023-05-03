public class Fraction
{
    private string _top;
    private string _bottom;

    public Fraction()
    {
        _top = "1";
        _bottom = "1";
    }
    public Fraction(string top)
    {
        _top = top;
        _bottom = "1";
    }
    public Fraction(string top, string bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public string GetTop()
    {
        return _top;
    }
    public void SetTop( string top)
    {
        _top = top;
    }
        public string GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(string bottom)
    {
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        return _top+"/"+_bottom;
    }
    public double GetDecimalValue()
    {
        double numarator = int.Parse(_top);
        double denominator = int.Parse(_bottom);
        double quotient = numarator/denominator;
        return quotient;
    }
}