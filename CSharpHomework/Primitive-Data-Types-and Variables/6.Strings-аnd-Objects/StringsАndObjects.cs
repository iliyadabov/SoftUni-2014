using System;

class StringsАndObjects
{
    static void Main()
    {
        string hallo = "Hallo";
        string world = "World";
        object halloWorld = hallo + " " + world;
        string result= halloWorld.ToString();
        Console.WriteLine(result);
    }
}
