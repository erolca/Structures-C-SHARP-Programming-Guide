public struct ComplexNumber
{
    public ComplexNumber(double real, double imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }

    public ComplexNumber(double real) : this()
    {
        this.real = real;
    }

    private double real;
    private double imaginary;
}

public class MainClass
{
    static void Main()
    {
        ComplexNumber valA = new ComplexNumber(1, 2);

        ComplexNumber valB = new ComplexNumber(5);
    }
}