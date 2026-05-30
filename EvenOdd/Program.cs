using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if(number % 2 == 0)
        {
            Console.WriteLine("The entered number is a even number");
        }
        else
        {
            Console.WriteLine("The entered number is a odd number");
        }
    }
}