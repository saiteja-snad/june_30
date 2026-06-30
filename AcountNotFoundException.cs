namespace Banking_Management_System.Exceptions
{
    public class AcountNotFoundException : Exception
    {
        public AcountNotFoundException(string message) : base(message)
        {
        }
    }
}
