namespace ProCultureApiClient.Contracts
{
    /// <summary>
    /// Class for getting event ID by ticket system INN and ticket system event ID
    /// </summary>
    public class GetEventIdRequest
    {
        public GetEventIdRequest(string systemInn, string systemEventId)
        { 
            SystemInn = systemInn;
            SystemEventId = systemEventId;
        }

        /// <summary>
        /// Ticket system organization INN
        /// </summary>
        public string SystemInn { get; set; }

        /// <summary>
        /// Ticket system event identifier
        /// </summary>
        public string SystemEventId { get; set; }
    }
}
