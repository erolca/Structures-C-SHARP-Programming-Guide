using System;

class MyClass
{
    public string x;
    public MyClass(string s)
    {
        x = s;
    }
}

struct MyStruct
{
    public MyClass refType;   // Ref type.
    public int valueType;     // Val type

    public MyStruct(string s)
    {
        refType = new MyClass(s);
        valueType = 9;
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        MyStruct valWithRef = new MyStruct("Initial value");
        valWithRef.valueType = 6;

        MyStruct valWithRef2;
        valWithRef2 = valWithRef;

        valWithRef2.refType.x = "I am NEW!";
        valWithRef2.valueType = 7;

        Console.WriteLine("Values after change:");
        Console.WriteLine("valWithRef.refType.x is {0}", valWithRef.refType.x);
        Console.WriteLine("valWithRef2.refType.x is {0}", valWithRef2.refType.x);
        Console.WriteLine("valWithRef.valueType is {0}", valWithRef.valueType);
        Console.WriteLine("valWithRef2.valueType is {0}", valWithRef2.valueType);
    }
}