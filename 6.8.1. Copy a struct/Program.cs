using System;

struct MyStruct
{
    public int x;

  

    public override string ToString()
    {
        return (string.Format("{0}",x));
    }
    
    
}

class MainClass
{
    public static void Main()
    {
        MyStruct a;
        MyStruct b;

        a.x = 10;
        b.x = 20;

       // Console.WriteLine("a.x {0}, b.x {1}", a.x, b.x);
        Console.WriteLine("a.x {0}, b.x {1}", a, b);

        a = b;
        b.x = 30;

        Console.WriteLine("a.x {0}, b.x {1}", a.x, b.x);
    }
}