using System;

namespace ObjectOrientedCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Josh", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

            account.MakeWithdrawal(120, DateTime.Now, "Hammock");
            account.MakeWithdrawal(50, DateTime.Now, "Xbox Game");


            Console.WriteLine(account.GetAccountHistory());


            // Test for a negative balance:
            try
            {
                account.MakeWithdrawal(100, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }

            // Test that the initial balances must be positive.
            try
            {
                var invalidAccount = new BankAccount("Invalid", 55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
            }
        }
    }
}