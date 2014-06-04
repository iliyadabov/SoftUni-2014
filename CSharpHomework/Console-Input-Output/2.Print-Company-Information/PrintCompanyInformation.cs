using System;


class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Company name: ");
        string cn = Console.ReadLine();
        Console.Write("Company address: ");
        string ca = Console.ReadLine();
        Console.Write("Phone number: ");
        string phone = Console.ReadLine();
        Console.Write("Fax number: ");
        string fax = Console.ReadLine();
        Console.Write("Web site: ");
        string web = Console.ReadLine();
        Console.Write("Manager first name: ");
        string mf = Console.ReadLine();
        Console.Write("Manager last name: ");
        string ml = Console.ReadLine();
        Console.Write("Manager age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Manager phone: ");
        string mphone = Console.ReadLine();

        Console.Clear();

        Console.WriteLine(cn);
        Console.WriteLine("Address: " + ca);
        Console.WriteLine("Tel. " + phone);
        Console.WriteLine("Fax: " + fax);
        Console.WriteLine("Web site: " + web);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})",mf,ml,age,mphone);

    }
}

