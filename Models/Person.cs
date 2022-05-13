using BankApp.Enums;
using BankApp.Models;
//using BankApp.Managers;

namespace BankApp.Models
{
    public abstract class Person
    {
        public Gender gender;
        private Staff.Gender gender1;

        public int Id 
        {
            get; set;
        }

        public string FirstName
        {
            get; set;
        }

        public string LastName
        {
            get; set;
        }

        public string Email
        {
            get; set;
        }

        public string Password
        {
            get; set;
        }

        public int PhoneNunmber
        {get; set;}

        public Gender Gender
        {
            get; set;
        }

        public string Address
        {
            get; set;
        }

        public DateTime DateOfBirth
        {
            get; set;
        }

        public Role Role
        {
            get; set;
        }

        protected Person(int id, string firstName, string lastName, string email, string password, int phoneNunmber, Gender gender, string address, DateTime dateOfBirth, Role role)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            PhoneNunmber = phoneNunmber;
            Gender = gender;
            Address = address;
            DateOfBirth = dateOfBirth;
            Role = role;
        }

        protected Person(int id, string firstName, string lastName, string email, string password, int phoneNunmber, Staff.Gender gender1, string address, DateTime dateOfBirth, Role role)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            PhoneNunmber = phoneNunmber;
            this.gender1 = gender1;
            Address = address;
            DateOfBirth = dateOfBirth;
            Role = role;
        }
    }
}