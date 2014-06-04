using System;

class BonusScore
{
    static void Main()
    {
        Console.Write("Enter score: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0 || n > 9)
        {
            Console.WriteLine("Invalid Score");
        }
        if (n >= 1 && n <= 3)
        {
            Console.WriteLine(n * 10);
        }
        if (n >= 4 && n <= 6)
        {
            Console.WriteLine(n * 100);
        }
        if (n >= 7 && n <= 9)
        {
            Console.WriteLine(n * 1000);
        }
    }
}


