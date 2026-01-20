// 1. Testing Banking Transactions
// Problem:
// Create a BankAccount class with:
// ● Deposit(double amount): Adds money to the balance.
// ● Withdraw(double amount): Reduces balance.
// ● GetBalance(): Returns the current balance.
// ✅ Write unit tests to check correct balance updates.
// ✅ Ensure withdrawals fail if funds are insufficient.

using System;

namespace CSharp_Advance_Programming.NUnit.TestingBankTransactions
{
    internal class Bank
    {
        private double balance;

        //non parameterised constructor
        public Bank()
        {
        }

        //parameterised constructor
        public Bank(double amount)
        {
            balance = amount;
        }

        public void Deposit(double amount)
        {
            if(amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }

            balance+=amount;
        }

        public void Withdrawl(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive.");
            }

            if(balance < amount)
            {
                throw new ArgumentException("Insufficient balance");
            }

            balance-=amount;
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}