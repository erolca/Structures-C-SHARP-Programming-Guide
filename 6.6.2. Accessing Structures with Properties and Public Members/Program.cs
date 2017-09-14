using System;

public struct StructWithPublicMembers
{
    public int X;
    public int Y;
}

public struct StructWithProperties
{
    private int PrivateX;
    private int PrivateY;

    public int X
    {
        get
        {
            return PrivateX;
        }
        set
        {
            PrivateX = value;
        }
    }

    public int Y
    {
        get
        {
            return PrivateY;
        }
        set
        {
            PrivateY = value;
        }
    }
}


public class MainClass
{
    public static void Main()
    {
        StructWithPublicMembers MembersStruct;
        StructWithProperties PropertiesStruct = new StructWithProperties();

        MembersStruct.X = 100;
        MembersStruct.Y = 200;

        PropertiesStruct.X = 100;
        PropertiesStruct.Y = 200;

        Console.WriteLine("MemberStruct {0} - {1}", MembersStruct.X, MembersStruct.Y);
        Console.WriteLine("PropertiesStruct {0} - {1}", PropertiesStruct.X, PropertiesStruct.Y);

    }
}