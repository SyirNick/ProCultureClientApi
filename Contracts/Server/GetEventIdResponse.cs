namespace ProCultureApiClient.Contracts
{
    /// <summary>
    /// Wrapper class for PRO.Culture.RF event ID in response from GetEventIdRequest
    /// </summary>
    public class GetEventIdResponse
    {
        public GetEventIdResponse(string systemInn, string systemEventId, string proEventId, EventStatus status)
        { 
            SystemInn = systemInn;
            SystemEventId = systemEventId;
            ProEventId = proEventId;
            Status = status;
        }

        /// <summary>
        /// Ticket organization INN
        /// </summary>
        public string SystemInn { get; set; }

        /// <summary>
        /// Ticket system event ID
        /// </summary>
        public string SystemEventId { get; set; }

        /// <summary>
        /// PRO.Culture.RF event ID
        /// </summary>
        public string ProEventId { get; set; }

        /// <summary>
        /// Event status
        /// </summary>
        public EventStatus Status { get; set; }
    }
}
