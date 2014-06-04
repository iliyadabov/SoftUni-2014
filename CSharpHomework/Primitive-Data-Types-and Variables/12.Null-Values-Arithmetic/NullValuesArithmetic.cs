using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? a = null;
        double? b = null;
        Console.WriteLine("Null:" + a);
        Console.WriteLine("Null:" + b);

        a += 8;
        b += 1.2;
        Console.WriteLine("Number + null:" + a);
        Console.WriteLine("Number + null:" + b);

        a = 8;
        b = 1.2;
        Console.WriteLine("Number:" + a);
        Console.WriteLine("Number:" + b);
    }
}

