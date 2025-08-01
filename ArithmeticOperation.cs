//WAP to add ,subtract,multiply,divide,and modulus of two numbers

namespace Operation;

public class ArithmeticOperation
{
    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Subtract(double a, double b)
    {

        return a - b;
    }

    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Can not divide by zero");
        }
        return a / b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public double Modulus(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Enter a valid number");

        }
        return a % b;
    }
}