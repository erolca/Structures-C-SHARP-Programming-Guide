using System;
struct Complex
{
    public Complex(float real, float imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }
    public override string ToString()
    {
        return (String.Format("({0}, {1})", real, imaginary));
    }

    public float real;
    public float imaginary;
} 

class MainClass
{
    public static void Main()
    {
        Complex[] arr = new Complex[10];
        arr[3].real = 5;
        arr[3].imaginary = 10;
        Console.WriteLine("Element 5: {0}", arr[5]);        // legal
        Console.WriteLine("Element 3: {0}", arr[3]);        // legal
    }
}