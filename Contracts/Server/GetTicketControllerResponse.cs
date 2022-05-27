namespace ProCultureApiClient.Contracts
{
    /// <summary>
    /// Wrapper class for controller ticket information response
    /// </summary>
    public class GetTicketControllerResponse
    {
        public GetTicketControllerResponse(TicketStatus status, Session session)
        {
            Status = status;
            Session = session;
        }

        /// <summary>
        /// Ticket status
        /// </summary>
        public TicketStatus Status { get; set; }

        /// <summary>
        /// Ticket session information
        /// </summary>
        public Session Session { get; set; }
    }
}
