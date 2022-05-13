using BankApp.Enums;
using BankApp.Models;
using BankApp.Managers;

namespace BankApp.Models
{
    public class Customer : Person
    {
        public string AccountNumber
        {
            get; set;
        }

        public string AccountBalance
        {
            get; set;
        }

        public int Pin
        {
            get; set;
        }
        
        public string AccountTypeName
        {
            get; set;
        }

        public Customer(int id, string firstName, string lastName, string email, string password, int phoneNunmber, Gender gender, string address, DateTime dateOfBirth, Role role, string accountNumber, string accountBalance, int pin, string accountTypeName):base(id,firstName,lastName,email,password,phoneNunmber,gender,address,dateOfBirth,role)
        {
            AccountNumber = accountNumber;
            AccountBalance = accountBalance;
            Pin = pin;
            AccountTypeName = accountTypeName;
        }
    }
}