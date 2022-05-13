using BankApp.Enums;
using BankApp.Models;
using BankApp.Managers;
namespace BankApp.Models
{
    public class Transaction
    {
        public int Id 
        {
            get; set;
        }
        public string CustomerName
        {
            get; set;
        }
        public string Details
        {
            get; set;
        }
        public DateTime Date
        {
            get; set;
        }
        public decimal Amount
        {
            get; set;
        }
        public TransactionType Type
        {
            get; set;
        }
        public string AccountNumber
        {
            get; set;
        }

        public Transaction(int id, string customername, string details, DateTime date, decimal amount, TransactionType type, string accountNumber)
        {
            Id = id;
            CustomerName = customername;
            Details = details;
            Date = date;
            Amount = amount;
            Type = type;
            AccountNumber = accountNumber;
        }
    }
}