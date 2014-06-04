using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter three number: ");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine("|{0,-15:X}|{1}|{2,15:F2}|{3,-15:F3}|", a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);


    }
}

