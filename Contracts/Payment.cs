using Newtonsoft.Json;

namespace ProCultureApiClient.Contracts
{
    /// <summary>
    /// Information about payment
    /// </summary>
    public class Payment
    {
        public Payment(string id, string rrn, int date, string ticketPrice, string amount)
        {
            Id = id;
            Rrn = rrn;
            Date = date;
            TicketPrice = ticketPrice;
            Amount = amount;
        }

        /// <summary>
        /// Ticket system payment ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Retrieval Reference Number
        /// </summary>
        public string Rrn { get; set; }

        /// <summary>
        /// Date and time of payment (unix timestamp)
        /// </summary>
        public int Date { get; set; }

        /// <summary>
        /// Ticket price
        /// </summary>
        [JsonProperty(PropertyName = "Ticket_Price")]
        public string TicketPrice { get; set; }

        /// <summary>
        /// Amount of ticket for Pushkin Card
        /// </summary>
        public string Amount { get; set; }
    }
}
