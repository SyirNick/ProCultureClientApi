using Newtonsoft.Json;

namespace ProCultureApiClient.Contracts
{
    /// <summary>
    /// Wrapper class that contains information about ticket refund request
    /// </summary>
    public class RefundTicketRequest
    {
        public RefundTicketRequest(int refundDate, string refundReason, string refundRrn, string refundTicketPrice, string comment)
        { 
            RefundDate = refundDate;
            RefundReason = refundReason;
            RefundRrn = refundRrn;
            RefundTicketPrice = refundTicketPrice;
            Comment = comment;
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
        /// Ticket refund Retrieval Reference Number
        /// </summary>
        [JsonProperty(PropertyName = "Refund_Rrn")]
        public string RefundRrn { get; set; }

        /// <summary>
        /// Ticket refund price
        /// </summary>
        [JsonProperty(PropertyName = "Refund_Ticket_Price")]
        public string RefundTicketPrice { get; set; }

        /// <summary>
        /// Ticket comment
        /// </summary>
        public string Comment { get; set; }
    }
}
