namespace Banking_Management_System.Exceptions
{
    public class InvalidBalanceException : Exception
    {
       
       
        public InvalidBalanceException(string? message) : base(message)
        {
        }
    }
}
