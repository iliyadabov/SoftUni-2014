﻿using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("Enter width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Enter height: ");
        double height = double.Parse(Console.ReadLine());

        double perimeter = 2 * (width + height);
        double area = width * height;

        Console.WriteLine("Perimeter = {0}",perimeter);
        Console.WriteLine("Area = {0}",area);
    }
}

