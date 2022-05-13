using BankApp.Enums;
using BankApp.Models;
using BankApp.Managers;

namespace BankApp.Managers
{
    public class TransactionManager
    {
        public static int NumOfTransactions = 0;
        public static List<Transaction> transactions = new List<Transaction>();

        public static void AddNewTransaction(string name, string details, decimal amount, TransactionType type, string accountnumber)
        {
            NumOfTransactions++;
            var date = DateTime.Now;
            Transaction transaction = new Transaction(NumOfTransactions, name, details, date, amount, type, accountnumber);
            transactions.Add(transaction);
        }

        private static void PrintTransaction(Transaction trans)
        {
            Console.WriteLine($"{trans.Id}\t{trans.CustomerName}\t{trans.Details}\t{trans.Date}\t{trans.Amount}\t{trans.Type}");
        }

        public static void GetAll()
        {
            foreach (var transact in transactions)
            {
                PrintTransaction(transact);
            }
        }
        public static void GetAllByDate(DateTime anydate)
        {
            foreach(var transact in transactions)
            {
                if(transact.Date.Date == anydate.Date)
                {
                    PrintTransaction(transact);
                }
            }
        }
        public static void GetAllByCustomer(string acctnum)
        {
            foreach (var transact in transactions)
            {
                if(transact.AccountNumber == acctnum)
                {
                    PrintTransaction(transact);
                }
            }
        }
        public static void GetAllByCustomerOnDate(string acctNum, DateTime anydate)
        {
            foreach(var transact in transactions)
            {
                if(transact.AccountNumber == acctNum && transact.Date.Date == anydate.Date)
                {
                    PrintTransaction(transact);
                }
            }
        }
    }
}