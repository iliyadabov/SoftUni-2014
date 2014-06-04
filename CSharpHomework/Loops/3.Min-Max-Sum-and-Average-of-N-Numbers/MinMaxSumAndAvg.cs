using System;

class MinMaxSumAndAvg
{
    static void Main()
    {
        Console.Write("Enter length of loop: ");
        int length = int.Parse(Console.ReadLine());

        double min = double.MaxValue;
        double max = double.MinValue;
        double sum = 0;
        double avg = 0;

        for (double i = 0; i < length; i++)
        {
            double n = double.Parse(Console.ReadLine());

            min = Math.Min(min, n);

            max = Math.Max(max, n);

            sum += n;

            avg = sum / length;
        }

        Console.WriteLine("Min = " + min);
        Console.WriteLine("Max = " + max);
        Console.WriteLine("Sum = " + sum);
        Console.WriteLine("Avg = {0:F2}", avg);
    }
}

