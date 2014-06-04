using System;

class SumOfnNumbers
{
    static void Main()
    {
        Console.Write("Enter limit of numbers: ");
        int n = int.Parse(Console.ReadLine());


        double result = 0;

        for (double i = 1; i < n+1; i++)
        {
            Console.Write("Number {0}: ", i);
            double number = double.Parse(Console.ReadLine());

            result += number;
        }

        Console.WriteLine("Result = " + result);
    }
}

