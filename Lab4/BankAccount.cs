using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class BankAccount
    {
        string AccountHolderName;
        decimal Amount;
        public BankAccount(string accountHolderName, decimal amount)
        {
            this.AccountHolderName = accountHolderName;
            this.Amount = amount;
        }

        public void Deposit(decimal cashAmount)
        {
            Amount += cashAmount;
            Console.WriteLine($"Deposited {cashAmount} in cash.");
        }

        public void Deposit(string chequeNumber, decimal chequeAmount)
        {
            Amount += chequeAmount;
            Console.WriteLine($"Deposited {chequeAmount} via cheque #{chequeNumber}.");
        }

        public void Withdraw(decimal cashAmount)
        {
            if (cashAmount <= Amount)
            {
                Amount -= cashAmount;
                Console.WriteLine($"Withdrawn {cashAmount} in cash.");
            }
            else
            {
                Console.WriteLine("Insufficient balance for cash withdrawal.");
            }
        }

        public void Withdraw(string chequeNumber, decimal chequeAmount)
        {
            if (chequeAmount <= Amount)
            {
                Amount -= chequeAmount;
                Console.WriteLine($"Withdrawn {chequeAmount} via cheque #{chequeNumber}.");
            }
            else
            {
                Console.WriteLine("Insufficient balance for cheque withdrawal.");
            }
        }

        public void ShowDetails()
        {
            Console.WriteLine($"\nAccount Holder : {AccountHolderName}");
            Console.WriteLine($"Balance : {Amount}");
        }

    }
}
