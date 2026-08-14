using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace BankAccountProject
{
    internal class BankAccount
    {
        public int AccountNumber {  get; private set; }
        public decimal Balance { get; private set; }
        public string Name { get; private set; }
        public BankAccount(int accountNumber, string name)
        {
            AccountNumber = accountNumber;
            Name = name;
            Balance = 0;
        }
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new Exception(" invaild number ... you should enter positive number ");

            Balance+= amount;

        }
        public void Withdraw(decimal amount)
        {

            if (amount <= 0)
            {
                throw new Exception(" invaild number ... you should enter positive number ");
            }
            
            if (amount > Balance)
            {
                throw new Exception("Balance is not enough for this withdrawal");

            }
            Balance -= amount;

        }

    }
}
