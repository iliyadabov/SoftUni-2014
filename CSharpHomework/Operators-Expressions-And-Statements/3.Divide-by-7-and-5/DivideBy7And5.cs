using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.Write("Enter Number: ");
        int n = int.Parse(Console.ReadLine());

        bool i = (n % 5 == 0) && (n % 7 == 0);

        Console.WriteLine("Divided by 7 and 5? ---> {0}", i);

    }
}