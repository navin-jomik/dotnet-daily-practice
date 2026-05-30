using System;
class Program
{
    static void Main()
    {
        int n, i;
        bool isPrime = true;

        Console.WriteLine("Enter a number:");
        n = Convert.ToInt32(Console.ReadLine());

        if (n <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (i = 0; i < n; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }
        if (isPrime)
        {
            Console.WriteLine("Prime Number");
        }
        else
        {
            Console.WriteLine("Not Prime Number");
        }
    }
}