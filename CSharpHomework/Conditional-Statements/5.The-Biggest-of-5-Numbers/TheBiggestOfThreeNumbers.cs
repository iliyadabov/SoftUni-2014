using System;

class TheBiggestOfThreeNumbers
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        if (a > b && a > c)
        {
            Console.WriteLine("Biggest = {0}", a);
        }
        if (b > a && b > c)
        {
            Console.WriteLine("Biggest = {0}", b);
        }
        if (c > a && c > b)
        {
            Console.WriteLine("Biggest = {0}", c);
        }
    }
}
