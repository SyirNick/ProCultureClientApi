using Newtonsoft.Json;

namespace ProCultureApiClient.Contracts
{
    /// <summary>
    /// Wrapper for response that contains information about ticket visit response
    /// </summary>
    public class VisitTicketResponse
    {
        public VisitTicketResponse(int visitDate, TicketStatus status)
        { 
            VisitDate = visitDate;
            Status = status;
        }

        /// <summary>
        /// Ticket visit date (unix timestamp)
        /// </summary>
        [JsonProperty(PropertyName = "Visit_Date")]
        public int VisitDate { get; set; }

        /// <summary>
        /// Ticket status
        /// </summary>
        public TicketStatus Status { get; set; }
    }
}
