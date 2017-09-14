using System;


//6.10.2.	struct objects have the same pass by value semantics as simple intrinsics

class Class1
{
    public static void Main(string[] args)
    {
        int i = 0;
        Console.WriteLine("Initial value of i = {0}", i);
        fn_int(i);
        Console.WriteLine("i after fn_int() = {0}", i);
        fn_Int32(i);
        Console.WriteLine("i after fn_Int32 = {0}", i);

        Console.WriteLine();

        Int32 i32 = 1;
        Console.WriteLine("Initial value of i32 = {0}", i32);
        fn_int(i32);
        Console.WriteLine("i32 after fn_int() = {0}", i32);
        fn_Int32(i32);
        Console.WriteLine("i32 after fn_Int32 = {0}", i32);
    }

    public static void fn_Int32(Int32 k)
    {
        k = 10;
    }


    public static void fn_int(int k)
    {
        k = 20;
    }
}