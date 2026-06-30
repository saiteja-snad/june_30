namespace Banking_Management_System.DTOS
{
    public class UpdateBankDto
    {
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
