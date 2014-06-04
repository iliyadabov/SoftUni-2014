using System;

class CheckForAPlayCard
{
    static void Main()
    {
        Console.Write("Enter play card: ");
        string n = Console.ReadLine();

        switch (n)
        {
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
            case "10":
            case "J":
            case "Q":
            case "K":
            case "A":
                Console.WriteLine("Valid card sign? ---> Yes"); break;
            default: Console.WriteLine("Valid card sign? ---> No"); break;
        }
    }

}