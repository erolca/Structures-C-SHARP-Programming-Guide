using System;

struct Point
{
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public override string ToString()
    {
        return (String.Format("({0}, {1})", x, y));
    }

    public int x;
    public int y;
}

class MainClass
{
    public static void Main()
    {
        Point start = new Point(5, 5);
        Console.WriteLine("Start: {0}", start);
        Console.WriteLine("{0}", String.Format("({0}, {1})", start.x, start.y));
    }
}

//Start: (5, 5)