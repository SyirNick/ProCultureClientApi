using Newtonsoft.Json;

namespace ProCultureApiClient.Contracts
{
    /// <summary>
    /// Wrapper for information about ticket refund response
    /// </summary>
    public class RefundTicketResponse
    {
        public RefundTicketResponse(int refundDate, string refundReason, string refundRrn, string refundTicketPrice, TicketStatus status)
        { 
            RefundDate = refundDate;
            RefundReason = refundReason;
            RefundRrn = refundRrn;
            RefundTicketPrice = refundTicketPrice;
            Status = status;
        }

        /// <summary>
        /// Ticket refund date (unix timestamp)
        /// </summary>
        [JsonProperty(PropertyName = "Refund_Date")]
        public int RefundDate { get; set; }

        /// <summary>
        /// Ticket refund reason
        /// </summary>
        [JsonProperty(PropertyName = "Refund_Reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// Refund transaction Retrieval Reference Number
        /// </summary>
        [JsonProperty(PropertyName = "Refund_Rrn")]
        public string RefundRrn { get; set; }
        
        /// <summary>
        /// Ticket refund price
        /// </summary>
        [JsonProperty(PropertyName = "Refund_Ticket_Price")]
        public string RefundTicketPrice { get; set; }

        /// <summary>
        /// Ticket status
        /// </summary>
        public TicketStatus Status { get; set; }
    }
}
