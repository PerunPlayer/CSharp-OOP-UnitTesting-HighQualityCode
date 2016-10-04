using BankAccounts.Contracts;
using System;

namespace BankAccounts.BankAccounts
{
    public class Mortgage : Account, IDepositable
    {
        public Mortgage(CustomerType customerType, decimal balance, decimal interestRate)
            : base(customerType, balance, interestRate)
        {

        }

        public override void CalculateInterest(int numOfMonths)
        {
            decimal interestAmmount = 0.00M;

            if (this.CustomerType == CustomerType.company && numOfMonths > 12)
            {
                interestAmmount = ((12 * (this.InterestRate / 100)) / 2) + ((numOfMonths - 12) * (this.InterestRate / 100));
            }

            else if (this.CustomerType == CustomerType.individual && numOfMonths > 6)
            {
                interestAmmount = (numOfMonths - 6) * (this.InterestRate / 100);
            }

            Console.WriteLine("Interest ammount: {0} - Period: {1} months - Balance: {2} ", interestAmmount, numOfMonths, this.Balance);
        }

        public void DepositMoney(decimal moneyToDeposit)
        {
            this.Balance -= moneyToDeposit;
            Console.WriteLine("Peid off to motgage: ${0} - Remaining: ${1}", moneyToDeposit, this.Balance);
        }
    }
}
