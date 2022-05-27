namespace ProCultureApiClient
{
    public class ProCultureException : Exception
    {
        public ProCultureException()
        {
        }

        public ProCultureException(string message)
            : base(message)
        {
        }

        public ProCultureException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
