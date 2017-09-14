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
}

public class MainClass
{
    public static void Main()
    {
        Car c1 = new Car("BMW", "330Ci", 2001);
        Car c2 = new Car("BMW", "330Ci", 2001);
        Console.WriteLine(c1.Equals(c2)); // Prints 'true'
        
    }

}