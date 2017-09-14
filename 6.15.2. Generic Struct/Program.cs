using System;
using System.Collections.Generic;

struct GenericStruct<T>
{
    private T _Data;
    public GenericStruct(T value) // construct..
    {
        _Data = value;
    }

    public T Data
    {
        get { return _Data; }
        set { _Data = value; }
    }
}

class MainClass
{
    static void Main()
    {
        GenericStruct<int> IntData = new GenericStruct<int>(10);
        GenericStruct<string> StringData = new GenericStruct<string>("str");

        Console.WriteLine("IntData    = {0}", IntData.Data);
        Console.WriteLine("StringData = {0}", StringData.Data);
    }
}