using System;

namespace BankAccountProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(1001, "Hamza Ahmed");

            Console.WriteLine($"Account created for {account.Name} | Balance: {account.Balance}");

            try
            {
                account.Deposit(500);
                Console.WriteLine($"After deposit -> Balance: {account.Balance}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            try
            {
                account.Withdraw(200);
                Console.WriteLine($"After withdraw -> Balance: {account.Balance}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            try
            {
                account.Deposit(150);
                Console.WriteLine($"After deposit -> Balance: {account.Balance}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}