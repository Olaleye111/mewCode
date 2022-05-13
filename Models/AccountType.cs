namespace BankApp.Models
{
    public class AccountType
    {
        public int Id
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public decimal Charges
        {
            get; set;
        }
        public decimal MinimumBal
        {
            get; set;
        }
        public decimal MaximumBal
        {
            get; set;
        }

        public AccountType(int id, string name, decimal charges, decimal minimumBal, decimal maximumBal)
        {
            Id = id;
            Name = name;
            Charges = charges;
            MinimumBal = minimumBal;
            MaximumBal = maximumBal;
        }
    }
}