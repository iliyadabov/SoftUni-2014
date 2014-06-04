using System;

class ExtractBit
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());

            int a = 1 << 3;
            int b = n & a;

            if (b == 0)
            {
                Console.WriteLine("Third bit is '0' " + Convert.ToString(n, 2).PadLeft(16, '0'));
            }
            else
            {
                Console.WriteLine("Third bit is '1' " + Convert.ToString(n, 2).PadLeft(16, '0'));
            }
        }
    }
}

