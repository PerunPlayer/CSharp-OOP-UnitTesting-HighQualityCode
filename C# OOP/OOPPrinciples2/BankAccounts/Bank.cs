using BankAccounts.BankAccounts;
using System.Collections.Generic;

namespace BankAccounts
{
    public static class Bank
    {
        private static List<Account> accounts = new List<Account>
            {
                new Deposit(CustomerType.company, 10000, 4),
                new Loan(CustomerType.individual, 5000, 2),
                new Mortgage(CustomerType.company, 1000000, 5),
                new Deposit(CustomerType.individual, 1100, 3),
                new Loan(CustomerType.company, 120000, 6)
            };

        public static List<Account> GetAccountData()
        {
            return accounts;
        }

        public static void DepositAccountActions()
        {
            Deposit acc = accounts[0] as Deposit;

            acc.DepositMoney(15000);
            acc.WithdrawMoney(25000);
        }

        public static void LoanAccountActions()
        {
            Loan acc = accounts[4] as Loan;

            acc.DepositMoney(1500);
        }

        public static void MortgageAccountActions()
        {
            Mortgage acc = accounts[2] as Mortgage;

            acc.DepositMoney(306000);
        }
    }
}
