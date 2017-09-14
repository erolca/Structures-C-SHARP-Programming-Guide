using System;

struct Point
{
    public int X;
    public int Y;
}

class MainClass
{
    static void Main()
    {
        Point p1, p2, p3;

        p1.X = 10; p1.Y = 10;
        p2.X = 20; p2.Y = 20;
        p3.X = p1.X + p2.X;
        p3.Y = p1.Y + p2.Y;

        Console.WriteLine("p1:  {0}, {1}", p1.X, p1.Y);
        Console.WriteLine("p2: {0}, {1}", p2.X, p2.Y);
        Console.WriteLine("p3:  {0}, {1}", p3.X, p3.Y);
    }
}

/*
 * p1:  10, 10
    p2: 20, 20
    p3:  30, 30

    */