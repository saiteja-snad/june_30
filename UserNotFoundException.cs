namespace Banking_Management_System.Exceptions
{
    public class UserNotFoundException : Exception
    {
       
        public UserNotFoundException(string? message) : base(message)
        {
        }
    }
}
