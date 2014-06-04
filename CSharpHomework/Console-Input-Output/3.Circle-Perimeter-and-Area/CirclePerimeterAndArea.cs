using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter radius: ");
        double n = double.Parse(Console.ReadLine());
        double p = ((2 * Math.PI) * n);
        double area = Math.PI *(n * n);

        Console.WriteLine("Perimeter = {0:F2}", p);
        Console.WriteLine("Area = {0:F2}",area);
    }
}
