using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount account = new CheckingAccount();

            Console.WriteLine("Enter how much loot you want to start with:");
            account.Deposit(Convert.ToDecimal(Console.ReadLine()));

            Console.WriteLine("Welcome to We Can Bank IT!");
            Console.WriteLine("Your account has $" + account.Balance);

            Console.WriteLine("1234567890\n" +
                "ABCDEFGHIJ\n" +
                "abcdefghij\n" +
                "1 3 5 7 9 \tTAB");

            Console.WriteLine("...Program Done... Press a key to exit");
            Console.ReadKey();

        }
    }
}
