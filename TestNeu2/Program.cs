using System;

namespace TestNeu2
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Dallas", 100000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

            Console.ReadKey();
        }
    }
}
