using System;
using System.Text;

class PrintTheASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        for (int i = 0; i <= 255; i++)
        {
            char ch = (char)i;
            Console.WriteLine("{0} ---> {1}",i,ch);
        }
    }
}

