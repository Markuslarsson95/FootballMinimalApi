namespace WebApp.Exceptions
{
    //this type should only be thrown within commands & queries to facilitate the return flow back to controller methods.
    [Serializable]
    public class CommandQueryMessageException : Exception
    {
        public int StatusCode { get; private set; }

        public CommandQueryMessageException()
        { }

        public CommandQueryMessageException(string message, int statusCode)
            : base(message)
        {
            StatusCode = statusCode;
        }

        public CommandQueryMessageException(string message, int statusCode, Exception innerException)
            : base(message, innerException)
        {
            StatusCode = statusCode;
        }
    }
}
