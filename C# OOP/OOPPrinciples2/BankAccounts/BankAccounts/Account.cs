using BankAccounts.Contracts;
using System;

namespace BankAccounts.BankAccounts
{
    public abstract class Account : IAccountable
    {
        private decimal balance;
        private decimal interestRate;
        private CustomerType customerType;

        public Account(CustomerType customerType, decimal balance, decimal interestRate)
        {
            this.CustomerType = customerType;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            protected set
            {
                this.balance = value;
            }
        }

        public CustomerType CustomerType
        {
            get
            {
                return this.customerType;
            }
            protected set
            {
                this.customerType = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Interest rage cannot be a negative number!");
                }
                this.interestRate = value;
            }
        }

        public abstract void CalculateInterest(int numOfMonths);

    }
}
