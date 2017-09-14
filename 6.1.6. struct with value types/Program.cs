using System;

struct PointerStruct
{
    public int x, y;
}

class MainClass
{
    public static void Main(string[] args)
    {

        // A struct is similar to a class, but is a value type, not a reference type.
        PointerStruct f1 = new PointerStruct();
        f1.x = 100;
        f1.y = 100;

        PointerStruct f2 = f1;

        Console.WriteLine("F1.x = {0}", f1.x);
        Console.WriteLine("F1.y = {0}", f1.y);

        Console.WriteLine("F2.x = {0}", f2.x);
        Console.WriteLine("F2.y = {0}", f2.y);

        Console.WriteLine("-> Changing f2.x");
        f2.x = 900;

        Console.WriteLine("F2.x = {0}", f2.x);
        Console.WriteLine("F1.x = {0}\n", f1.x);

    }
}