using System;


class BankAccountData
{
    static void Main()
    {
        string firstName = "Iliya";
        string middleName = "Dimitrov";
        string lastName = "Dabov";
        decimal balance = 12583.23m;
        string lv = "lv.";
        string bankName = "Fibank";
        string iban = "BG80 BNBG 9661 1020 3456 78";
        string masterCard = "5105 1051 0510 5100";
        string visaElectron = "4012 8888 8888 1881";
        string americanExpres = "3782 8224 6310 005";

        Console.WriteLine("Full Name: {0} {1} {2}",firstName,middleName,lastName);
        Console.WriteLine("Balance: {0} {1}",balance,lv);
        Console.WriteLine("Bank Name: {0}",bankName);
        Console.WriteLine("IBAN: {0}",iban);
        Console.WriteLine("Master Card: {0}",masterCard);
        Console.WriteLine("Visa Electron: {0}",visaElectron);
        Console.WriteLine("American Expres: {0}",americanExpres);
        
    }
}

