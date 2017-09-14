﻿using System;
using System.Collections.Generic;
using System.Text;



class MyClass
{
    public int val;
}

struct myStruct
{
    public int val;
}

class Program
{
    static void Main(string[] args)
    {
        MyClass objectA = new MyClass();
        MyClass objectB = objectA;
        //refernaslar aynı
       // A struct is similar to a class, but is a value type, not a reference type.
        objectA.val = 10;
        objectB.val = 20;
        myStruct structA = new myStruct();
        myStruct structB = structA;
        structA.val = 30;
        structB.val = 40;
        Console.WriteLine("objectA.val = {0}", objectA.val);
        Console.WriteLine("objectB.val = {0}", objectB.val);
        Console.WriteLine("structA.val = {0}", structA.val);
        Console.WriteLine("structB.val = {0}", structB.val);
    }
}