using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int target = int.Parse(Console.ReadLine());

        Console.WriteLine("The multiplication table for:" + target);
        for(int i = 1; i <= 12; i++)
        {
            int product = target * i;
            Console.WriteLine("The product of " + target + " is " + product);
        }
    }
}