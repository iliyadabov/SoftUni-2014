using System;

class BitsExchange
{
    static void Main()
    {
        Console.Write("Enter your number: ");
        long n = long.Parse(Console.ReadLine());

        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));

        int a = 3;
        int b = 24;

        for (int i = 0; i < 3; i++)
        {
            long maskOne = (n & (1 << a)) >> a;
            long maskTwo = (n & (1 << b)) >> b;

            if (maskOne == 0)
            {
                n = n & (~(1 << b));
            }
            else if (maskOne == 1)
            {
                n = n | (1 << b);
            }

            if (maskTwo == 0)
            {
                n = n & (~(1 << a));
            }
            else if (maskTwo == 1)
            {
                n = n | (1 << a);
            }

            a++;
            b++;
        }

        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine(n);
    }
}

