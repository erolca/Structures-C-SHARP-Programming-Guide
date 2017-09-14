using System;

public struct Fraction
{

    public Fraction(double _divisor, double _dividend)
    {
        divisor = _divisor;
        dividend = _dividend;
    }

    public double quotient
    {
        get
        {
            return divisor / dividend;
        }
    }

    private double divisor;
    private double dividend;

}

public class Calculate
{
    public static void Main()
    {
        Fraction number = new Fraction(4, 5);
        Console.WriteLine("{0}", number.quotient);
    }
}