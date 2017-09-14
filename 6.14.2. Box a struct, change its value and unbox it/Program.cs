using System;
public interface IModifyMyStruct
{
    int X
    {
        get;
        set;
    }
}

public struct MyStruct : IModifyMyStruct
{
    public int x;

    public int X
    {
        get
        {
            return x;
        }

        set
        {
            x = value;
        }
    }

    public override string ToString()
    {
        return x.ToString();
    }
}

public class MainClass
{
    static void Main()
    {
        MyStruct myval = new MyStruct();
        myval.x = 123;

        object obj = myval;
        System.Console.WriteLine("{0}", obj.ToString());

        IModifyMyStruct iface = (IModifyMyStruct)obj;
        iface.X = 456;
        System.Console.WriteLine("{0}", obj.ToString());

        MyStruct newval = (MyStruct)obj;
        System.Console.WriteLine("{0}", newval.ToString());
    }
}