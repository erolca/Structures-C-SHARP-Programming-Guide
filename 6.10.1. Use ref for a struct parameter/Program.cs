using System;


class Ornek
{
    string adi;
    public string Adi { get; set; } = "erolca";
}

public struct MyStruct
{

    //CTRL + R +E;
    public int val;
    public int MyProperty { get; set; }
}

public class MainClass
{
    static void Main()
    {
        MyStruct myValue = new MyStruct();
        myValue.val = 10;

        PassByValue(myValue);
        Console.WriteLine("Result of PassByValue: myValue.val = {0}", myValue.val);

        PassByRef(ref myValue);
        Console.WriteLine("Result of PassByRef: myValue.val = {0}", myValue.val);
    }

    static void PassByValue(MyStruct myValue)
    {
        myValue.val = 50;
    }

    static void PassByRef(ref MyStruct myValue)
    {
        myValue.val = 42;
    }
}

/*
  Result of PassByValue: myValue.val = 10
    Result of PassByRef: myValue.val = 42

    */
