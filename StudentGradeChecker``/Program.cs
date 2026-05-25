using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();

        Console.Write("Enter marks (0-100): ");
        int marks = Convert.ToInt32(Console.ReadLine());

        if (marks < 0 || marks > 100)
        {
            Console.WriteLine("Invalid marks entered!");
        }
        else if (marks >= 90)
        {
            Console.WriteLine(name + " scored Grade A+");
        }
        else if (marks >= 75)
        {
            Console.WriteLine(name + " scored Grade A");
        }
        else if (marks >= 60)
        {
            Console.WriteLine(name + " scored Grade B");
        }
        else if (marks >= 40)
        {
            Console.WriteLine(name + " scored Grade C");
        }
        else
        {
            Console.WriteLine(name + " failed.");
        }
    }
}