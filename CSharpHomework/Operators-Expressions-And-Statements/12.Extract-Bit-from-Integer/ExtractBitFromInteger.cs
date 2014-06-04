using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Check bit of position: ");
        int p = int.Parse(Console.ReadLine());

        int a = 1 << p;
        int b = n & a;

        if (b == 0)
        {
            Console.WriteLine("Bit of position {0} is '0'", p);
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));
        }
        else
        {
            Console.WriteLine("Bit of position {0} is '1'", p);
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));
        }
    }
}

