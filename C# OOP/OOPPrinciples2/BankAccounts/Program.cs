namespace BankAccounts
{
    using System;

    class Program
    {
        static void Main()
        {
            var accounts = Bank.GetAccountData();
            Console.WriteLine("Calculating interest ammount of bank accounts! \n");
            foreach (var account in accounts)
            {
                account.CalculateInterest(24);
            }
            Console.WriteLine("\nBank account actions! \n");
            Bank.DepositAccountActions();
            Bank.LoanAccountActions();
            Bank.MortgageAccountActions();
        }
    }
}
