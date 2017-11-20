using System;
using System.Linq;

namespace Topic.D.Examples
{
    public class Account
    {
        public string BankName { get; set; }
        public int BranchNumber { get; set; }
        public int InstitutionNumber { get; set; }
        public int AccountNumber { get; set; }
        public double Balance { get; set; }
        public double OverdraftLimit { get; set; }
        public string AccountType { get; set; }
        public Account(string bankName, int branchNumber, int institutionNumber, int accountNumber, double balance, double overdraftLimit, string accountType)
        {
            BankName = bankName;
            BranchNumber = branchNumber;
            InstitutionNumber = institutionNumber;
            AccountNumber = accountNumber;
            Balance = balance;
            OverdraftLimit = overdraftLimit;
            AccountType = accountType;
        }
    }
}
