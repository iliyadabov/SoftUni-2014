using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Enter your number: ");
        int n = int.Parse(Console.ReadLine());


        int a = n % 10;
        int two = n / 10;
        int b = two % 10;
        int three = n / 100;
        int c = three % 10;
        int four = n / 1000;
        int d = four % 10;

        Console.WriteLine("Number: " + n);
        Console.WriteLine("Sum of digits = " + (a + b + c + d));
        Console.WriteLine("Reversed = {0}{1}{2}{3}", a, b, c, d);
        Console.WriteLine("Last digit in front = {0}{1}{2}{3}", a, d, c, b);
        Console.WriteLine("Second and third digits exchanged = {0}{1}{2}{3}", d, b, c, a);
    }
}

