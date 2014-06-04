using System;

class ThirdDigitIs7
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());

        int a = n / 100;
        int b = a % 10;
        bool result = (b == 7);

        Console.WriteLine("The third digit from right to left is 7 ? ---> {0}", result);

    }

}