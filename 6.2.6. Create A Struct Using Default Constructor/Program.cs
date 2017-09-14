using System;

public struct Location
{
    public int X { get; set; }
    public int Y { get; set; }

    public Location(int x, int y)
        : this()
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return (String.Format("{0}, {1}", X, Y));
    }

}

public class Tester
{
    static void Main()
    {
        Location loc1 = new Location();  // no call to the constructor
        loc1.X = 75;
        loc1.Y = 225;
        Console.WriteLine(loc1);
        Console.WriteLine("{0}",String.Format("{0}, {1}", loc1.X, loc1.Y));
    }
}