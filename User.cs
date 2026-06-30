namespace Banking_Management_System.Models
{
    public class User
    {
        private int userId;
        private string userName;
        private string password;
        private string role;

        public User()
        {
        }

        public User(int userId, string userName, string password, string role)
        {
            this.UserId = userId;
            this.UserName = userName;
            this.Password = password;
            this.Role = role;
        }

        public int UserId { get => userId; set => userId = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
    }
}
