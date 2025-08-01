// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using Operation;
 class Demo
{
    public static void Main(string[] args)
    {
        ArithmeticOperation obj = new ArithmeticOperation();

        Console.WriteLine("Enter a number ");
        string number1 = Console.ReadLine();
        double num1 = double.Parse(number1);

        Console.WriteLine("Enter another number");
        string number2 = Console.ReadLine();
        double num2 = double.Parse(number2);

        double sum = obj.Add(num1,num2);
        double sub = obj.Subtract(num1,num2);
        double div = obj.Divide(num1,num2);
        double mul = obj.Multiply(num1,num2);
        double mod = obj.Modulus(num1,num2);



        Console.WriteLine("choose operation");
        Console.WriteLine("1.Add ");
        Console.WriteLine("2.Subtract");
        Console.WriteLine("3.divide");
        Console.WriteLine("4.multiply");
        Console.WriteLine("5.modulus");
        Console.WriteLine("Enter your choic");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                obj.Add(num1,num2);
                Console.WriteLine($"sum is :{sum}");
                break;

            case "2":
                obj.Subtract(num1, num2);
                Console.WriteLine($"subtraction is : {sub}");
                break;

            case "3":
                obj.Divide(num1, num2);
                Console.WriteLine($"divide is :{ div}");
                break;

            case "4":
                obj.Multiply(num1, num2);
                Console.WriteLine($"Multiply is :{ mul}");
                break;

            case "5":
                obj.Modulus(num1, num2);
                Console.WriteLine($"Modulas  is :{ mod}");
                break;

            default:
                Console.WriteLine("invalid number");
                break;



         




        }

        
        
    }
}