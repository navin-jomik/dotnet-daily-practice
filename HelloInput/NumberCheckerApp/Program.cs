using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a Number:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Even Number");
        }
        else
        {
            Console.WriteLine("Odd Number");
        }
    }
}