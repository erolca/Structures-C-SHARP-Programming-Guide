using System;


public struct Simple
{

    public int i;
    private string s;

    public void init()
    {
        i = 10;
        s = "Hello";
    }

}



public class MainClass
{

    public static void Main()
    {

        Simple simple = new Simple();

        simple.init();

    }
}