using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

struct StructWithNoMembers
{
}

struct StructWithMembers
{
    short s;
    int i;
    long l;
    bool b;
}

struct CompositeStruct
{
    StructWithNoMembers a;
    StructWithMembers b;
    StructWithNoMembers c;
}

class SizeofCustomTypesApp
{
    unsafe public static void Main(string[] args)
    {
        Console.WriteLine("sizeof StructWithNoMembers structure = {0}", sizeof(StructWithNoMembers));
        Console.WriteLine("sizeof StructWithMembers structure = {0}", sizeof(StructWithMembers));
        Console.WriteLine("sizeof CompositeStruct structure = {0}", sizeof(CompositeStruct));
    }
}