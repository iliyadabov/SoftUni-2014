using System;

class FibonacciNumbers
{
    static void Main()
    {
        decimal a = -1;
        decimal b = 1;

        Console.Write("Enter number: ");

        decimal n = decimal.Parse(Console.ReadLine());

        for (decimal i = 0; i < n; i++)
        {

            decimal c = b + a;
            a = b;
            b = c;

            Console.WriteLine(b);
        }
    }
}

