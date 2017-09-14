
using System;

public class Employee
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}

public class Manager : Employee
{
    private string name;

    // Notice the use of the new modifier:
    public new string Name
    {
        get {
            //return name;
           /* In the previous code segment, 
            if you do not assign a value to the Name property,
            it will return the value NA.*/
            return name != null ? name : "NA";
        }
        set { name = value + ", Manager"; }
    }
}