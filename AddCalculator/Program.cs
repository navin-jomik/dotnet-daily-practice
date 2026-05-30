using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Simple Calculator of addition");

        Console.WriteLine("Enter first number:");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        double number2 = Convert.ToDouble(Console.ReadLine());

        double result = number1 + number2;

        Console.WriteLine("The sum of two double values entered is:" + result);
    }
}