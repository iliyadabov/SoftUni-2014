using System;

class ModifyBit
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Check bit of position: ");
        int p = int.Parse(Console.ReadLine());

        Console.Write("Value of bit [0 or 1]: ");
        int value = int.Parse(Console.ReadLine());

        Console.WriteLine("Binary representation of n = " + Convert.ToString(n, 2).PadLeft(16, '0'));

        if (value == 1)
        {
            int a = 1 << p;
            int b = n | a;
            Console.WriteLine("Binary result = " + Convert.ToString(b, 2).PadLeft(16, '0'));
            Console.WriteLine("Result = " + b);
        }

        else
        {
            int c = ~(1 << p);
            int d = n & c;
            Console.WriteLine("Binary result = " + Convert.ToString(d, 2).PadLeft(16, '0'));
            Console.WriteLine("Result = " + d);
        }
    }
}

