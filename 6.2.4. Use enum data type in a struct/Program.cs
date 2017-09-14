using System;

enum EmpType : byte
{
    Manager = 10,
    Developer = 1,
    Contractor = 100,
    Programmer = 9
}

struct EMPLOYEE
{
    public EmpType title;
    public string name;
    public short deptID;

    public EMPLOYEE(EmpType et, string n, short d)
    {
        title = et;
        name = n;
        deptID = d;
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        EMPLOYEE fred;
        fred.deptID = 40;
        fred.name = "Fred";
        fred.title = EmpType.Developer;

        EMPLOYEE mary = new EMPLOYEE(EmpType.Programmer, "Mary", 10);

    }
}