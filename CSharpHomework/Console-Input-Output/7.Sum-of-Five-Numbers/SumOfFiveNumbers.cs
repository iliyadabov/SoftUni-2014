using System;

class SumOfFiveNumbers
{
    static void Main()
    {
        Console.Write("Enter five numbers separated by a space: ");
        string[] numbers = Console.ReadLine().Split();

        int a = int.Parse(numbers[0]);
        int b = int.Parse(numbers[1]);
        int c = int.Parse(numbers[2]);
        int d = int.Parse(numbers[3]);
        int e = int.Parse(numbers[4]);

        Console.WriteLine("Result = {0}", a + b + c + d + e);
    }
}


