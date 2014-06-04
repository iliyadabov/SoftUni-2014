using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        string copy = "\u00A9";
        Console.OutputEncoding = Encoding.UTF8;

        // Variant 1
        Console.WriteLine("   {0}\n  {0} {0}\n {0}   {0}\n{0} {0} {0} {0}", copy);

        // Variant 2
        Console.WriteLine("   {0}   ", copy);
        Console.WriteLine("  {0} {0}   ", copy);
        Console.WriteLine(" {0}   {0}  ", copy);
        Console.WriteLine("{0} {0} {0} {0}  ", copy);

    }
}
