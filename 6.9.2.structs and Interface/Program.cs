using System;

interface IPromotion
{

    void promote();

}

struct Employee : IPromotion
{

    public string Name;

    public int JobGrade;

    public void promote()
    {

        JobGrade++;

    }

    public Employee(string name, int jobGrade)
    {

        this.Name = name;

        this.JobGrade = jobGrade;

    }

    public override string ToString()
    {

        return string.Format("{0} ({1})", Name, JobGrade);

    }

}

class Program

{

    static void Main(string[] args)

    {

        Employee employee = new Employee("Cool Guy", 65);

        IPromotion p = employee;

        Console.WriteLine(employee);

        p.promote();

        Console.WriteLine(employee);

    }

}