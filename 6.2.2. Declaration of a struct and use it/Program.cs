using System;

public struct MyStruct
{
    public int MyInt;
    public long MyLong;
    public string MyString;
}

class MainClass
{
    static void Main(string[] args)
    {
        MyStruct TheStruct;

        TheStruct.MyInt = 0;
        TheStruct.MyLong = 0;
        TheStruct.MyString = "Hello World";
    }
}