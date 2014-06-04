using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("d = ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("e = ");
        double e = double.Parse(Console.ReadLine());

        if (a > b && a > c && a > d && a > e)
        {
            Console.WriteLine("Biggest = {0}", a);
        }
        if (b > a && b > c && b > d && b > e)
        {
            Console.WriteLine("Biggest = {0}", b);
        }
        if (c > a && c > b && c > d && c > e)
        {
            Console.WriteLine("Biggest = {0}", c);
        }
        if (d > a && d > b && d > c && d > e)
        {
            Console.WriteLine("Biggest = {0}", d);
        }
        if (e > a && e > b && e > c && e > d)
        {
            Console.WriteLine("Biggest = {0}", e);
        }
    }
}

