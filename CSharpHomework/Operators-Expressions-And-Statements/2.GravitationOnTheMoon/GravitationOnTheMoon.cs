using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.Write("Enter weight on the Earth: ");
        double number = double.Parse(Console.ReadLine());

        Console.WriteLine("Weight on the Moon = {0}", number * 0.17);
    }
}
