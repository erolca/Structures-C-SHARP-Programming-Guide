using System;

struct EMPLOYEE
{
    public string name;
    public short deptID;

    public EMPLOYEE(string n, short d)
    {
        name = n;
        deptID = d;
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        EMPLOYEE fred = new EMPLOYEE("s", 1);
        fred.name = "Tesla";

        object stanInBox = fred;

        UnboxThisEmployee(stanInBox);
    }
    public static void UnboxThisEmployee(object o)
    {
        EMPLOYEE temp = (EMPLOYEE)o;
        Console.WriteLine(temp.name);
    }

}