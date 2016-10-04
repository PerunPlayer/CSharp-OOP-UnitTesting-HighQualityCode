using BankAccounts.Contracts;
using System;

namespace BankAccounts.BankAccounts
{
    public class Loan : Account, IDepositable
    {
        public Loan(CustomerType customerType, decimal balance, decimal interestRate)
            : base(customerType, balance, interestRate)
        {

        }

        public override void CalculateInterest(int numOfMonths)
        {
            decimal interestAmmount = 0.00M;

            if (this.CustomerType == CustomerType.individual && numOfMonths > 3)
            {
                interestAmmount = (numOfMonths - 3) * (this.InterestRate / 100);
            }
            else if (this.CustomerType == CustomerType.company && numOfMonths > 2)
            {
                interestAmmount = (numOfMonths - 2) * (this.InterestRate / 100);
            }

            Console.WriteLine("Interest ammount: {0} - Period: {1} months - Balance: {2} ", interestAmmount, numOfMonths, this.Balance);
        }

        public void DepositMoney(decimal moneyToDeposit)
        {
            this.Balance -= moneyToDeposit;
            Console.WriteLine("Paid off to loan: ${0} - Remaining: ${1}", moneyToDeposit, this.Balance);
        }
    }
}
