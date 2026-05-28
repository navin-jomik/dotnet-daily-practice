using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int n=Convert.ToInt32(Console.ReadLine());

        if (n % 2 == 0)
        {
            Console.WriteLine("The entered number is a Even number");
        }
        else
        {
            Console.WriteLine("The entered number is a Odd number");
        }
    }
}