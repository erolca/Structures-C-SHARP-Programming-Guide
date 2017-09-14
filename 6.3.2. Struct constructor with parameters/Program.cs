using System;

struct Point
{
    public int x;
    public int y;
    public Point(int a, int b)
    {
        x = a;
        y = b;
    }
}

class MainClass
{
    static void Main()
    {
        Point p1 = new Point();
        Point p2 = new Point(5, 10);

        Console.WriteLine("{0},{1}", p1.x, p1.y);
        Console.WriteLine("{0},{1}", p2.x, p2.y);
    }
}