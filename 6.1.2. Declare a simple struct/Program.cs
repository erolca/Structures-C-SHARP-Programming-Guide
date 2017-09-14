using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

struct Fraction
{
    public int numerator;
    public int denominator;

    public override string ToString()
    {
        return "(" + numerator + "," + denominator + ")";
    }

}

public class MainClass
{
    public static void Main()
    {
        Fraction f;
        f.numerator = 5;
        f.denominator = 10;

        // now  new trial

        unsafe
        {
            Fraction point;
            Fraction* p = &point;
            (*p).denominator = 12;
            (*p).numerator = 24;
            Console.WriteLine((*p).ToString());
        }
      

    }
}