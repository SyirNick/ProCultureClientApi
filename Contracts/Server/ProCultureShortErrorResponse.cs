namespace ProCultureApiClient.Contracts
{
    /// <summary>
    /// Short variation of error response from PRO.Culture.RF
    /// </summary>
    public class ProCultureShortErrorResponse
    {
        public ProCultureShortErrorResponse(string code, string description)
        {
            Code = code;
            Description = description;
        }

        /// <summary>
        /// Error code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Error description
        /// </summary>
        public string Description { get; set; }
    }
}