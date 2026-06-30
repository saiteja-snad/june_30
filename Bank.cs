using System.ComponentModel.DataAnnotations;

namespace Banking_Management_System.Models
{
    public class Bank
    {
        private int accountNumber;
        private string coustomerName;
        private string email;
        private string phone;
        private string address;
        private string accountType;
        private int balance;
        private string branch;
        private string ifscCode;
        private string accountStatus;
        private DateTime? createdDate;

        public Bank()
        {
        }

        public Bank(int accountNumber, string coustomerName, string email, string phone, string address, string accountType, int balance, string branch, string ifscCode, string accountStatus, DateTime? createdDate)
        {
            this.AccountNumber = accountNumber;
            this.CoustomerName = coustomerName;
            this.Email = email;
            this.Phone = phone;
            this.Address = address;
            this.AccountType = accountType;
            this.Balance = balance;
            this.Branch = branch;
            this.IfscCode = ifscCode;
            this.AccountStatus = accountStatus;
            this.CreatedDate = createdDate;
        }
        [Key]
        public int AccountNumber { get => accountNumber; set => accountNumber = value; }
        public string CoustomerName { get => coustomerName; set => coustomerName = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string AccountType { get => accountType; set => accountType = value; }
        public int Balance { get => balance; set => balance = value; }
        public string Branch { get => branch; set => branch = value; }
        public string IfscCode { get => ifscCode; set => ifscCode = value; }
        public string AccountStatus { get => accountStatus; set => accountStatus = value; }
        public DateTime? CreatedDate { get => createdDate; set => createdDate = value; }
    }
}
