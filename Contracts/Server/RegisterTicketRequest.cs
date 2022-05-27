using Newtonsoft.Json;

namespace ProCultureApiClient.Contracts
{
    /// <summary>
    /// Wrapper for class that contains information about ticket information
    /// </summary>
    public class RegisterTicketRequest
    {
        public RegisterTicketRequest(string barcode, string barcodeType, Visitor visitor, Buyer buyer, Session session, Payment payment, string comment)
        { 
            Barcode = barcode;
            BarcodeType = barcodeType;
            Visitor = visitor;
            Buyer = buyer;
            Session = session;
            Payment = payment;
            Comment = comment;
        }

        /// <summary>
        /// Ticket barcode or QR-Code
        /// </summary>
        public string Barcode { get; set; }

        /// <summary>
        /// Type of ticket barcode;<br></br>
        /// Instruction of how to fill this field: <a href="https://bit.ly/3GmUQb1">.docx-file download hyperlink</a>
        /// </summary>
        [JsonProperty(PropertyName = "Barcode_Type")]
        public string BarcodeType { get; set; }

        /// <summary>
        /// Ticket visitor
        /// </summary>
        public Visitor Visitor { get; set; }

        /// <summary>
        /// Ticket buyer
        /// </summary>
        public Buyer Buyer { get; set; }

        /// <summary>
        /// Ticket pay session
        /// </summary>
        public Session Session { get; set; }

        /// <summary>
        /// Ticket payment
        /// </summary>
        public Payment Payment { get; set; }

        /// <summary>
        /// Ticket comment
        /// </summary>
        public string Comment { get; set; }
    }
}
