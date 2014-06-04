using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());

        // if (a > b)
        // {
        //     Console.WriteLine("Greater = {0}", a);
        // }
        // else 
        // {
        //     Console.WriteLine("Greater = {0}", b);
        // }

        double result = Math.Max(a, b);
        Console.WriteLine("Greater = {0}", result);
    }
}

