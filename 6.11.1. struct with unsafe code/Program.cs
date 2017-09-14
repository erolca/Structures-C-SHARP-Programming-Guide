using System;
using System.Globalization;

public struct Node
{
    public int Value;
    public unsafe Node* Left;
    public unsafe Node* Right;
}

public class MainClass
{

    static void Main(string[] args)
    {
        Node n = new Node();
        n.Value = 9;
    }
}