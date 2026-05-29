using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter number1:");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter number2:");
        int number2 = Convert.ToInt32(Console.ReadLine());
        int sum = number1 + number2;
        Console.WriteLine("Sum of number1 and number 2 is:" + sum);
    }
}