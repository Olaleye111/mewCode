using BankApp.Enums;

namespace BankApp.Models
{
    public class Staff : Person
    {
        public string StaffNumber
        {
            get; set;
        }

        public Staff(int id, string firstName, string lastName, string email, string password, int phoneNunmber, Gender gender, string address, DateTime dateOfBirth, Role role, string staffNumber):base(id,firstName,lastName,email,password,phoneNunmber,gender,address,dateOfBirth,role)
        {
            StaffNumber = staffNumber;
        }

        internal class Gender
        {
        }

        // public class Gender
        // {
        // }
    }
}