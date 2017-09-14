using System;


public interface IDisplay
{
    void Print();
}

public struct MyStruct : IDisplay
{
    public int x;

    public void Print()
    {
        System.Console.WriteLine("{0}", x);
    }
}

public class MainClass
{
    static void Main()
    {
        MyStruct myval = new MyStruct();
        myval.x = 123;

        // no boxing
        myval.Print();

        // must box the value
        IDisplay printer = myval;
  
        printer.Print();
    }
}