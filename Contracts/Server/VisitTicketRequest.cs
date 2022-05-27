using Newtonsoft.Json;

namespace ProCultureApiClient.Contracts
{
    /// <summary>
    /// Wrapper for information about ticket visit
    /// </summary>
    public class VisitTicketRequest
    {
        public VisitTicketRequest(int visitDate, string comment)
        { 
            VisitDate = visitDate;
            Comment = comment;
        }

        /// <summary>
        /// Ticket visit date (unix timestamp)
        /// </summary>
        [JsonProperty(PropertyName = "Visit_Date")]
        public int VisitDate { get; set; }

        /// <summary>
        /// Ticket visit comment
        /// </summary>
        public string Comment { get; set; }
    }
}
