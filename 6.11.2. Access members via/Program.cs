using System;
using System.Globalization;


//	6.11.2.	Access members via ->
//foo->bar() is the same as (*foo).bar().

//Arrow opertoru ->
// see http://www.c4learn.com/c-programming/c-arrow-operator/

struct Point
{
    public int x;
    public int y;

    // metod ezme
    public override string ToString()
    {
        return "(" + x + "," + y + ")";
    }
}


public class MainClass
{

    static void Main(string[] args)
    {
        Console.WriteLine("Access members via ->");
        unsafe
        {
            Point point; // struct variable...
            Point* p = &point; //object pointer
            p->x = 100; // arrow operator..
            p->y = 200;
            (*p).y = 250;
            Console.WriteLine(p->ToString());
        }
    }
}