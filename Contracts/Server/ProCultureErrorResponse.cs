namespace ProCultureApiClient.Contracts
{
    /// <summary>
    /// PRO.Culture.RF errors that not equals 200 OK wrapper
    /// </summary>
    public class ProCultureErrorResponse
    {
        public ProCultureErrorResponse(string error, string errorName, string userMessage)
        { 
            Error = error;
            ErrorName = errorName;
            UserMessage = userMessage;
        }

        /// <summary>
        /// Error
        /// </summary>
        public string Error { get; set; }

        /// <summary>
        /// Error name
        /// </summary>
        public string ErrorName { get; set; }

        /// <summary>
        /// A message for an user
        /// </summary>
        public string UserMessage { get; set; }
    }
}
