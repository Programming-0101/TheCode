using System;
using System.Linq;

namespace Topic.I.Examples
{
    public enum AccountType
    {
        Chequing, Savings, CreditCard, LineOfCredit
    }
    public class Account
    {
        public Account(string bankName, int branchNumber, int institutionNumber,
                int accountNumber, double balance, double overdraftLimit,
                AccountType type)
        {
            if (string.IsNullOrEmpty(bankName) ||
                string.IsNullOrEmpty(bankName.Trim()))
                throw new System.Exception("Bank name cannot be empty");
            if (branchNumber < 10000 || branchNumber > 99999)
                throw new System.Exception("Branch number must be 5 digits");
            if (institutionNumber < 100 || institutionNumber > 999)
                throw new System.Exception("Institution number must be 3 digits");
            if (balance <= 0)
                throw new System.Exception("Opening balance must be greater than zero");
            OverdraftLimit = overdraftLimit;
            this.BankName = bankName;
            this.BranchNumber = branchNumber;
            this.InstitutionNumber = institutionNumber;
            this.AccountNumber = accountNumber;
            this.Balance = balance;
            this.Type = type;
        }

        private double _overdraftLimit;

        public double Balance { get; private set; }
        public string BankName { get; private set; }
        public int BranchNumber { get; private set; }
        public int InstitutionNumber { get; private set; }
        public int AccountNumber { get; private set; }
        public AccountType Type { get; private set; }

        public double OverdraftLimit
        {
            get
            { return _overdraftLimit; }
            set
            {
                if (value < 0)
                    throw new System.Exception("Negative overdraft limits not allowed");
                this._overdraftLimit = value;
            }
        }

        public bool IsOverdrawn()
        {
            return Balance < 0.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public double Withdraw(double amount)
        {
            if (amount > Balance + _overdraftLimit)
                throw new System.Exception("Insufficient Funds");
            Balance -= amount;
            return amount;
        }
    }
}
