using System;

class CheckBit
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Check bit of position: ");
        int p = int.Parse(Console.ReadLine());

        int a = n >> p;
        int b = a & 1;

        bool i = b == 1;

        Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));
        Console.WriteLine("Bit of position {0} is '1' = {1}", p, i);
    }
}

