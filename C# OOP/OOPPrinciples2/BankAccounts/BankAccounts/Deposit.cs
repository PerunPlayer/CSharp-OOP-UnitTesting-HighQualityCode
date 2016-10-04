using BankAccounts.Contracts;
using System;

namespace BankAccounts.BankAccounts
{
    public class Deposit : Account, IDepositable, IWithdrawable
    {
        public Deposit(CustomerType customerType, decimal balance, decimal interestRate)
            : base(customerType, balance, interestRate)
        {

        }

        public override void CalculateInterest(int numOfMonths)
        {
            decimal interestAmmount = 0.00M;

            if (this.Balance > 0 && this.Balance < 1000)
            {
                interestAmmount = 0;
            }
            else
            {
                interestAmmount = (this.InterestRate / 100) * numOfMonths;
            }

            Console.WriteLine("Interest ammount: {0} - Period: {1} months - Balance: {2} ", interestAmmount, numOfMonths, this.Balance);
        }

        public void DepositMoney(decimal moneyToDeposit)
        {
            this.Balance += moneyToDeposit;
            Console.WriteLine("Deposited: ${0} - Balance: ${1}", moneyToDeposit, this.Balance);
        }

        public void WithdrawMoney(decimal moneyToWithdraw)
        {
            this.Balance -= moneyToWithdraw;
            Console.WriteLine("Withdrawn: ${0} - Balance: ${1}", moneyToWithdraw, this.Balance);
        }
    }
}
