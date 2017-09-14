using System;
using System.Globalization;


//foo->bar() is the same as (*foo).bar().
struct Point
{
    public int x;
    public int y;
    public override string ToString()
    {
        return "(" + x + "," + y + ")";
    }
}


public class MainClass
{

    static void Main(string[] args)
    {
        Console.WriteLine("Access members via.");
        unsafe
        {
            Point point;
            Point* p = &point;
            (*p).x = 100;
            (*p).y = 200;
            p->y = 250;
            Console.WriteLine((*p).ToString());
        }
    }
}