using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Security.Cryptography;

struct Car
{
    public string Make;
    public string Model;
    public uint Year;

    public Car(string make, string model, uint year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public bool Equals(Car c)
    {
        return c.Make == this.Make &&
            c.Model == this.Model &&
            c.Year == this.Year;
    }

    public override bool Equals(object obj)
    {
        if (obj is Car)
            return Equals((Car)obj);
        return false;
    }
}

public class MainClass
{
    public static void Main()
    {
        Car c1 = new Car("A", "4", 2005);
        Car c2 = new Car("A", "4", 2005);
        Console.WriteLine(c1.Equals(c2)); // Prints 'true'
    }

}