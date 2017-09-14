using System;
public struct Rectangle
{
    // declare the fields
    public int Width;
    public int Height;

    // define a constructor
    public Rectangle(int Width, int Height)
    {
        this.Width = Width;
        this.Height = Height;
    }

    // define the Area() method
    public int Area()
    {
        return Width * Height;
    }

}


class MainClass
{

    public static void Main()
    {
        System.Console.WriteLine("Creating a Rectangle instance");
        Rectangle myRectangle = new Rectangle(2, 3);

        System.Console.WriteLine("myRectangle.Width = " + myRectangle.Width);
        System.Console.WriteLine("myRectangle.Height = " + myRectangle.Height);
        System.Console.WriteLine("myRectangle.Area() = " + myRectangle.Area());
    }
}