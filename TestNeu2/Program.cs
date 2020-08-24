using System;

namespace TestNeu2
{
    class Program
    {
        static void Main(string[] args)
        {
            var currency = "$";
            var account = new BankAccount("Dallas", 100000, currency);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} {currency}.");

            account.MakeWithdrawal(15000, DateTime.Now, "Guns", currency);
            account.MakeWithdrawal(1350, DateTime.Now, "Masks", currency);
            account.MakeWithdrawal(1500, DateTime.Now, "Getaway Driver", currency);
            account.MakeWithdrawal(5000, DateTime.Now, "Equipment", currency);

            Console.WriteLine(account.GetAccountHistory());
            
            // // Test for a negative balance:
            // try 
            // {
            //     account.MakeWithdrawal(750000, DateTime.Now, "Attempt to overdraw");
            // }
            // catch (InvalidOperationException e) 
            // {
            //     Console.WriteLine("Exception caught trying to overdraw");
            //     Console.WriteLine(e.ToString());
            // }

            //  // Test that the initial balances must be positive.
            // try
            // {
            //     var invalidAccount = new BankAccount("invalid", -55);
            // }
            // catch (ArgumentOutOfRangeException e)
            // {
            //     Console.WriteLine("Exception caught creating account with negative balance");
            //     Console.WriteLine(e.ToString());
            // }
            
            Console.ReadKey();
        }
    }
}
