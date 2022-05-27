using Newtonsoft.Json;

namespace ProCultureApiClient.Contracts
{
    /// <summary>
    /// Wrapper class for response that contains information about ticket registration
    /// </summary>
    public class RegisterTicketResponse
    {
        public RegisterTicketResponse(string id, string barcode, TicketStatus status, Visitor visitor, Buyer buyer, Session session,
            Payment payment, int visitDate, int refundDate, string refundReason, string refundRrn, string refundTicketPrice, string comment)
        { 
            Id = id;
            Barcode = barcode;
            Status = status;
            Visitor = visitor;
            Buyer = buyer;
            Session = session;
            Payment = payment;
            VisitDate = visitDate;
            RefundDate = refundDate;
            RefundReason = refundReason;
            RefundRrn = refundRrn;
            RefundTicketPrice = refundTicketPrice;
            Comment = comment;
        }

        /// <summary>
        /// Ticket ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Ticket barcode or QR-Code
        /// </summary>
        public string Barcode { get; set; }

        /// <summary>
        /// Ticket status
        /// </summary>
        public TicketStatus Status { get; set; }

        /// <summary>
        /// Ticket visitor
        /// </summary>
        public Visitor Visitor { get; set; }

        /// <summary>
        /// Ticket buyer
        /// </summary>
        public Buyer Buyer { get; set; }

        /// <summary>
        /// Ticket session
        /// </summary>
        public Session Session { get; set; }

        /// <summary>
        /// Ticket payment
        /// </summary>
        public Payment Payment { get; set; }

        /// <summary>
        /// Ticket refund date (unix timestamp)
        /// </summary>
        [JsonProperty(PropertyName = "Visit_Date")]
        public int VisitDate { get; set; }

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
        /// Transaction refund Retrieval Reference Number
        /// </summary>
        [JsonProperty(PropertyName = "Refund_Rrn")]
        public string RefundRrn { get; set; }

        /// <summary>
        /// Amount of refund
        /// </summary>
        [JsonProperty(PropertyName = "Refund_Ticket_Price")]
        public string RefundTicketPrice { get; set; }

        /// <summary>
        /// Ticket comment
        /// </summary>
        public string Comment { get; set; }
    }
}
