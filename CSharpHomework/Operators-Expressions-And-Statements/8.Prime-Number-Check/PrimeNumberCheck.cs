using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());

        bool i = false;

        if (n == 0 || n == 1)
        {
            Console.WriteLine("Prime ---> {0}", i);
        }
        else if (n == 2 || n == 3 || n == 5 || n == 7)
        {
            i = true;
            Console.WriteLine("Prime ---> {0}", i);
        }
        else if (n % 2 == 0 || n % 3 == 0 || n % 4 == 0 || n % 5 == 0 ||
                 n % 6 == 0 || n % 7 == 0 || n % 8 == 0 || n % 9 == 0 || n % 10 == 0)
        {
            Console.WriteLine("Prime? ---> {0}", i);
        }
        else
        {
            i = true;
            Console.WriteLine("Prime ---> {0}", i);
        }
    }
}

