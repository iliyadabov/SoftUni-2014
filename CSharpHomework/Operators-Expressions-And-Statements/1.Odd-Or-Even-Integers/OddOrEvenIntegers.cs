using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.Write("Enter number: ");

        int n = int.Parse(Console.ReadLine());

        Console.Write("Odd? ---> ");


        if (n % 2 == 0)
        {
            Console.WriteLine(false);
        }
        else
        {
            Console.WriteLine(true);
        }
    }
}

