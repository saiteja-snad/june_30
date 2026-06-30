namespace Banking_Management_System.Exceptions
{
    public class DuplicateAccountException : Exception
    {
        public DuplicateAccountException(string? message) : base(message)
        {
        }
    }
}
