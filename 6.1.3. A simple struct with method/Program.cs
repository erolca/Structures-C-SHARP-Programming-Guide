using System;

struct Fraction
{

    public int numerator;
    public int denominator;

    public void Print()
    {
        Console.WriteLine("{0}/{1}", numerator, denominator);
    }
}

public class MainClass
{

    public static void Main()
    {
        Fraction f;
        f.numerator = 5;
        f.denominator = 10;
        f.Print();

        Fraction f2 = f;
        f.Print();

        f2.numerator = 1;
        f.Print();
        f2.Print();
    }
}

/*
5/10
5/10
5/10
1/10
*/