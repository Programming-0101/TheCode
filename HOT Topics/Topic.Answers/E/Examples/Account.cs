using System;
using System.Linq;

namespace Topic.E.Examples
{
    public class Account
    {
        public int AccountNumber { get; private set; }
        public double Balance { get; private set; }
        public double OverdraftLimit { get; set; }
        public string AccountType { get; private set; }
        public string BankName { get; private set; }
        public int BranchNumber { get; private set; }
        public int InstitutionNumber { get; private set; }

        public Account(string bankName, int branchNumber, int institutionNumber, int accountNumber, double balance, double overdraftLimit, string accountType)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            OverdraftLimit = overdraftLimit;
            AccountType = accountType;
            BankName = bankName;
            BranchNumber = branchNumber;
            InstitutionNumber = institutionNumber;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
